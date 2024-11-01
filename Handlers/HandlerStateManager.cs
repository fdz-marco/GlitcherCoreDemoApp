﻿using glitcher.core;
using glitcher.core.Servers;
using System.Reflection;
using System.Windows.Forms;
using Servers = glitcher.core.Servers;
using Clients = glitcher.core.Clients;
using Databases = glitcher.core.Databases;

namespace GlitcherCoreDemoApp
{
    public class HandlerStateManager
    {
        Servers.LightHTTPServer _httpServer = null;
        Servers.WebSocketServer _wsServer = null;
        Clients.MQTTClient _mqttClient = null;
        Databases.SQLiteClient _sqLiteClient = null;
        Databases.MySQLClient _mySqlClient = null;
        Form form = null;

        public HandlerStateManager(Form form, 
            ref Servers.LightHTTPServer _httpServer, ref Servers.WebSocketServer _wsServer, 
            ref Clients.MQTTClient _mqttClient,
            ref Databases.SQLiteClient _sqLiteClient, ref Databases.MySQLClient _mySqlClient
            )
        {
            this.form = form;
            this._httpServer = _httpServer;
            this._wsServer = _wsServer;
            this._mqttClient = _mqttClient;
            this._sqLiteClient = _sqLiteClient;
            this._mySqlClient = _mySqlClient;

            _httpServer.ChangeOccurred += _httpServer_ChangeOccurred;
            _wsServer.ChangeOccurred += _wsServer_ChangeOccurred;
            _mqttClient.ChangeOccurred += _mqttClient_ChangeOccurred;
            _sqLiteClient.ChangeOccurred += _sqLiteClient_ChangeOccurred;
            _mySqlClient.ChangeOccurred += _mySqlClient_ChangeOccurred;
        }

        private void CheckStateAllDone()
        {
            CheckedListBox chkLb_State = (CheckedListBox)Utils.FindControlRecursive(this.form, "chkLb_State");

            if (chkLb_State.CheckedItems.Count == (chkLb_State.Items.Count - 1))
                chkLb_State.SetItemChecked(chkLb_State.Items.Count - 1, true);
            else
                chkLb_State.SetItemChecked(chkLb_State.Items.Count - 1, false);
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

        private void _wsServer_ChangeOccurred(object? sender, WebSocketServerEvent e)
        {
            CheckedListBox chkLb_State = (CheckedListBox)Utils.FindControlRecursive(this.form, "chkLb_State");

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

        private void _mqttClient_ChangeOccurred(object? sender, Clients.MQTTClientEvent e)
        {
            CheckedListBox chkLb_State = (CheckedListBox)Utils.FindControlRecursive(this.form, "chkLb_State");

            if (e.eventType == "connected")
                chkLb_State.SetItemChecked(4, true);
            if (e.eventType == "disconnected")
            {
                chkLb_State.SetItemChecked(4, false);
            }
            CheckStateAllDone();
        }

        private void _sqLiteClient_ChangeOccurred(object? sender, Databases.SQLiteClientEvent e)
        {
            CheckedListBox chkLb_State = (CheckedListBox)Utils.FindControlRecursive(this.form, "chkLb_State");

            if (e.eventType == "connected")
                chkLb_State.SetItemChecked(5, true);
            if (e.eventType == "disconnected")
            {
                chkLb_State.SetItemChecked(5, false);
            }
            CheckStateAllDone();
        }

        private void _mySqlClient_ChangeOccurred(object? sender, Databases.MySQLClientEvent e)
        {
            CheckedListBox chkLb_State = (CheckedListBox)Utils.FindControlRecursive(this.form, "chkLb_State");

            if (e.eventType == "connected")
                chkLb_State.SetItemChecked(6, true);
            if (e.eventType == "disconnected")
            {
                chkLb_State.SetItemChecked(6, false);
            }
            CheckStateAllDone();
        }

    }
}
