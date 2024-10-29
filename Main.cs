using glitcher.core;
using glitcher.core.Servers;
using System.Reflection;
using System.Windows.Forms;
using Servers = glitcher.core.Servers;
using Clients = glitcher.core.Clients;

namespace GlitcherCoreDemoApp
{
    public partial class Main : Form
    {
        private Servers.LightHTTPServer? _httpServer = null;
        private Servers.WebSocketServer _wsServer = null;
        private Clients.MQTTClient _mqttClient = null;
        private SystemTray? _sysTray = null;

        public Main()
        {
            InitializeComponent();
            Utils.SetAssemblyRemote(Assembly.GetExecutingAssembly());
            _httpServer = new Servers.LightHTTPServer(8080, 10, "Html", "www", false, false);
            _httpServer.ServeFirstLocal = true;
            _wsServer = new Servers.WebSocketServer(8081, 10, "", false);
            _mqttClient = new Clients.MQTTClient("localhost", 1883, "", "", Clients.MQTTClient.Protocol.mqtt, false);
            _sysTray = new SystemTray();
            Init_SystemTray();
            new HandlerStateManager(this, ref _httpServer, ref _wsServer, ref _mqttClient);
        }

        #region SysTray

        public void Init_SystemTray()
        {
            _sysTray.AddItemAtTop("Open Web Browser", (object s, EventArgs e) =>
            {
                if (_httpServer != null)
                {
                    if (_httpServer.endpoints != null)
                        if (_httpServer.endpoints.Count > 0)
                            Utils.OpenWebBrowser(_httpServer.endpoints[0]);
                }
            }, "Resources/IconOpenWebBrowser.png");
        }

        #endregion

        #region HTTP Server

        private void btn_Update_HTTP_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_Port_HTTP.Text.Trim(), out int port);
            int.TryParse(txt_MaxConnections_HTTP.Text.Trim(), out int maxConnections);
            string basePathLocal = txt_BasePathLocal_HTTP.Text.Trim();
            bool allowCORS = chk_AllowCORS_HTTP.Checked;
            bool ServeFirstLocal = chk_ServeFirstLocal_HTTP.Checked;
            bool restartOnUpdate = chk_RestartOnUpdate_HTTP.Checked;
            _httpServer.ServeFirstLocal = ServeFirstLocal;
            _httpServer.Update(port, maxConnections, basePathLocal, allowCORS, restartOnUpdate);
        }

        private void btn_Start_HTTP_Click(object sender, EventArgs e)
        {
            if (_httpServer != null)
            {
                _httpServer.Start();
            }
        }

        private void btn_Stop_HTTP_Click(object sender, EventArgs e)
        {
            if (_httpServer != null)
            {
                _httpServer.Stop();
            }
        }

        #endregion

        #region WebSocket Server

        private void btn_Update_WS_Click(object sender, EventArgs e)
        {
            if (_wsServer != null)
            {
                int.TryParse(txt_Port_WS.Text.Trim(), out int port);
                int.TryParse(txt_MaxConnections_WS.Text.Trim(), out int maxConnections);
                string APIKey = txt_APIKey_WS.Text.Trim();
                bool restartOnUpdate = chk_RestartOnUpdate_WS.Checked;
                _wsServer.Update(port, maxConnections, APIKey, restartOnUpdate);
            }
        }

        private void btn_Start_WS_Click(object sender, EventArgs e)
        {
            if (_wsServer != null)
            {
                _wsServer.Start();
            }
        }

        private void btn_Stop_WS_Click(object sender, EventArgs e)
        {
            if (_wsServer != null)
            {
                _wsServer.Stop();
            }
        }

        #endregion

        #region MQTT Client

        private void btn_Start_MQTT_Click(object sender, EventArgs e)
        {
            if (_mqttClient != null)
            {
                _mqttClient.Start();
            }
        }

        private void btn_Stop_MQTT_Click(object sender, EventArgs e)
        {
            if (_mqttClient != null)
            {
                _mqttClient.Stop();
            }
        }

        private async void btn_Update_MQTT_Click(object sender, EventArgs e)
        {
            string host = txt_Host_MQTT.Text.Trim();
            int.TryParse(txt_Port_MQTT.Text.Trim(), out int port);
            string user = txt_Username_MQTT.Text.Trim();
            string pswd = txt_Password_MQTT.Text.Trim();
            bool restartOnUpdate = chk_RestartOnUpdate_MQTT.Checked;
            await _mqttClient.Update(host, port, user, pswd, Clients.MQTTClient.Protocol.mqtt, restartOnUpdate);
        }

        private async void btn_TopicSubscribe_MQTT_Click(object sender, EventArgs e)
        {
            string topic = txt_TopicSubscribe_MQTT.Text.Trim();
            await _mqttClient.SubscribeTopic(topic);
        }

        private async void btn_TopicPublish_MQTT_Click(object sender, EventArgs e)
        {
            string topic = txt_TopicPublish_Topic_MQTT.Text.Trim();
            string payload = txt_TopicPublish_Payload_MQTT.Text.Trim();
            await _mqttClient.PublishTopic(topic, payload);
        }

        #endregion

        #region Quick Tools

        private void btn_Open_LogViewer_Click(object sender, EventArgs e)
        {
            LogViewer.GetInstance().Show();
            LogViewer.GetInstance().Focus();

        }

        private void btn_Open_AppFolder_Click(object sender, EventArgs e)
        {
            Utils.OpenAppFolder();
        }

        private void btn_Open_Browser_Click(object sender, EventArgs e)
        {
            if (_httpServer != null)
            {
                if (_httpServer.endpoints != null)
                    if (_httpServer.endpoints.Count > 0)
                        Utils.OpenWebBrowser(_httpServer.endpoints[0]);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            _httpServer.Start();
            _wsServer.Start();
            _mqttClient.Start();
        }

        #endregion



    }
}
