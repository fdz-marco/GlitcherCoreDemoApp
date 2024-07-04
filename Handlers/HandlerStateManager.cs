using glitcher.core;
using glitcher.core.Servers;
using System.Reflection;
using System.Windows.Forms;
using Servers = glitcher.core.Servers;

namespace GlitcherCoreDemoApp
{
    public class HandlerStateManager
    {
        Servers.LightHTTPServer _httpServer = null;
        Servers.WebSocketServer _wsServer = null;
        Form form = null;

        public HandlerStateManager(Form form, ref Servers.LightHTTPServer _httpServer, ref Servers.WebSocketServer _wsServer)
        {
            this.form = form;
            this._httpServer = _httpServer;
            this._wsServer = _wsServer;
            _httpServer.ChangeOccurred += _httpServer_ChangeOccurred;
            _wsServer.ChangeOccurred += _wsServer_ChangeOccurred;
        }

        private void CheckStateAllDone()
        {
            CheckedListBox chkLb_State = (CheckedListBox)Utils.FindControlRecursive(this.form, "chkLb_State");

            if (chkLb_State.CheckedItems.Count == (chkLb_State.Items.Count - 1))
                chkLb_State.SetItemChecked(chkLb_State.Items.Count - 1, true);
            else
                chkLb_State.SetItemChecked(chkLb_State.Items.Count - 1, false);
        }

        private void _wsServer_ChangeOccurred(object? sender, WebSocketServerEvent e)
        {
            CheckedListBox chkLb_State = (CheckedListBox) Utils.FindControlRecursive(this.form, "chkLb_State");

            if (e.eventType == "started")
                chkLb_State.SetItemChecked(2, true);
            if (e.eventType == "running")
                chkLb_State.SetItemChecked(3, true);
            if (e.eventType == "stopped")
            {
                chkLb_State.SetItemChecked(2, false);
                chkLb_State.SetItemChecked(3, false);
            }
            CheckStateAllDone();
        }

        private void _httpServer_ChangeOccurred(object? sender, LightHTTPServerEvent e)
        {
            CheckedListBox chkLb_State = (CheckedListBox)Utils.FindControlRecursive(this.form, "chkLb_State");

            if (e.eventType == "started")
                chkLb_State.SetItemChecked(0, true);
            if (e.eventType == "running")
                chkLb_State.SetItemChecked(1, true);
            if (e.eventType == "stopped")
            {
                chkLb_State.SetItemChecked(0, false);
                chkLb_State.SetItemChecked(1, false);
            }
            CheckStateAllDone();
        }

    }
}
