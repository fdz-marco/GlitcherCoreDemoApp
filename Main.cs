using glitcher.core;
using glitcher.core.Servers;
using System.Reflection;
using System.Windows.Forms;
using Servers = glitcher.core.Servers;

namespace GlitcherCoreDemoApp
{
    public partial class Main : Form
    {
        private Servers.LightHTTPServer? _httpServer = null;
        private Servers.WebSocketServer _wsServer = null;
        private SystemTray? _sysTray = null;

        public Main()
        {
            InitializeComponent();
            Utils.SetAssemblyRemote(Assembly.GetExecutingAssembly());
            _httpServer = new Servers.LightHTTPServer(8080, 10, "Html", "www", false, false);
            _httpServer.ServeFirstLocal = true;
            _wsServer = new Servers.WebSocketServer(8081, 10, "", false);
            _sysTray = new SystemTray();
            Init_SystemTray();
            new HandlerStateManager(this, ref _httpServer, ref _wsServer);
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
        }

        #endregion

    }
}
