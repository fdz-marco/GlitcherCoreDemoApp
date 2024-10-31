namespace GlitcherCoreDemoApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbx_HTTP = new GroupBox();
            btn_Stop_HTTP = new Button();
            chk_RestartOnUpdate_HTTP = new CheckBox();
            btn_Start_HTTP = new Button();
            chk_ServeFirstLocal_HTTP = new CheckBox();
            btn_Update_HTTP = new Button();
            chk_AllowCORS_HTTP = new CheckBox();
            txt_MaxConnections_HTTP = new TextBox();
            txt_BasePathLocal_HTTP = new TextBox();
            txt_Port_HTTP = new TextBox();
            lbl_BasePathLocal_HTTP = new Label();
            lbl_MaxConnections_HTTP = new Label();
            lbl_Port_HTTP = new Label();
            grbx_WS = new GroupBox();
            btn_Stop_WS = new Button();
            btn_Start_WS = new Button();
            lbl_APIKey_WS = new Label();
            btn_Update_WS = new Button();
            txt_APIKey_WS = new TextBox();
            chk_RestartOnUpdate_WS = new CheckBox();
            txt_MaxConnections_WS = new TextBox();
            txt_Port_WS = new TextBox();
            lbl_MaxConnections_WS = new Label();
            lbl_Port_WS = new Label();
            grbx_QuickTools = new GroupBox();
            btn_Open_Browser = new Button();
            btn_Start = new Button();
            btn_Open_AppFolder = new Button();
            btn_Open_LogViewer = new Button();
            grbx_Status = new GroupBox();
            chkLb_State = new CheckedListBox();
            grbx_MQTT = new GroupBox();
            lbl_TopicSubscribe_MQTT = new Label();
            lbl_TopicPublish_Topic_MQTT = new Label();
            lbl_TopicPublish_Payload_MQTT = new Label();
            txt_TopicPublish_Payload_MQTT = new TextBox();
            btn_TopicPublish_MQTT = new Button();
            txt_TopicPublish_Topic_MQTT = new TextBox();
            btn_TopicSubscribe_MQTT = new Button();
            txt_TopicSubscribe_MQTT = new TextBox();
            chk_RestartOnUpdate_MQTT = new CheckBox();
            btn_Stop_MQTT = new Button();
            btn_Start_MQTT = new Button();
            txt_Password_MQTT = new TextBox();
            btn_Update_MQTT = new Button();
            txt_Username_MQTT = new TextBox();
            lbl_Username_MQTT = new Label();
            lbl_Password_MQTT = new Label();
            txt_Port_MQTT = new TextBox();
            txt_Host_MQTT = new TextBox();
            lbl_Host_MQTT = new Label();
            lbl_Port_MQTT = new Label();
            grbx_SQLite = new GroupBox();
            chk_RestartOnUpdate_SQLite = new CheckBox();
            btn_Disconnect_SQLite = new Button();
            btn_Connect_SQLite = new Button();
            btn_Update_SQLite = new Button();
            txt_Server_SQLite = new TextBox();
            lbl_Server_SQLite = new Label();
            grbx_MySQL = new GroupBox();
            txt_Database_MySQL = new TextBox();
            lbl_Database_MySQL = new Label();
            chk_RestartOnUpdate_MySQL = new CheckBox();
            btn_Disconnect_MySQL = new Button();
            btn_Connect_MySQL = new Button();
            txt_Password_MySQL = new TextBox();
            btn_Update_MySQL = new Button();
            txt_Username_MySQL = new TextBox();
            lbl_Username_MySQL = new Label();
            lbl_Password_MySQL = new Label();
            txt_Port_MySQL = new TextBox();
            txt_Server_MySQL = new TextBox();
            lbl_Server_MySQL = new Label();
            lbl_Port_MySQL = new Label();
            grbx_HTTP.SuspendLayout();
            grbx_WS.SuspendLayout();
            grbx_QuickTools.SuspendLayout();
            grbx_Status.SuspendLayout();
            grbx_MQTT.SuspendLayout();
            grbx_SQLite.SuspendLayout();
            grbx_MySQL.SuspendLayout();
            SuspendLayout();
            // 
            // grbx_HTTP
            // 
            grbx_HTTP.BackColor = Color.LavenderBlush;
            grbx_HTTP.Controls.Add(btn_Stop_HTTP);
            grbx_HTTP.Controls.Add(chk_RestartOnUpdate_HTTP);
            grbx_HTTP.Controls.Add(btn_Start_HTTP);
            grbx_HTTP.Controls.Add(chk_ServeFirstLocal_HTTP);
            grbx_HTTP.Controls.Add(btn_Update_HTTP);
            grbx_HTTP.Controls.Add(chk_AllowCORS_HTTP);
            grbx_HTTP.Controls.Add(txt_MaxConnections_HTTP);
            grbx_HTTP.Controls.Add(txt_BasePathLocal_HTTP);
            grbx_HTTP.Controls.Add(txt_Port_HTTP);
            grbx_HTTP.Controls.Add(lbl_BasePathLocal_HTTP);
            grbx_HTTP.Controls.Add(lbl_MaxConnections_HTTP);
            grbx_HTTP.Controls.Add(lbl_Port_HTTP);
            grbx_HTTP.Location = new Point(14, 15);
            grbx_HTTP.Margin = new Padding(3, 4, 3, 4);
            grbx_HTTP.Name = "grbx_HTTP";
            grbx_HTTP.Padding = new Padding(3, 4, 3, 4);
            grbx_HTTP.Size = new Size(376, 274);
            grbx_HTTP.TabIndex = 0;
            grbx_HTTP.TabStop = false;
            grbx_HTTP.Text = "HTTP Server Settings";
            // 
            // btn_Stop_HTTP
            // 
            btn_Stop_HTTP.Location = new Point(250, 225);
            btn_Stop_HTTP.Name = "btn_Stop_HTTP";
            btn_Stop_HTTP.Size = new Size(114, 30);
            btn_Stop_HTTP.TabIndex = 18;
            btn_Stop_HTTP.Text = "Stop";
            btn_Stop_HTTP.UseVisualStyleBackColor = true;
            btn_Stop_HTTP.Click += btn_Stop_HTTP_Click;
            // 
            // chk_RestartOnUpdate_HTTP
            // 
            chk_RestartOnUpdate_HTTP.AutoSize = true;
            chk_RestartOnUpdate_HTTP.Checked = true;
            chk_RestartOnUpdate_HTTP.CheckState = CheckState.Checked;
            chk_RestartOnUpdate_HTTP.Location = new Point(8, 196);
            chk_RestartOnUpdate_HTTP.Name = "chk_RestartOnUpdate_HTTP";
            chk_RestartOnUpdate_HTTP.Size = new Size(140, 23);
            chk_RestartOnUpdate_HTTP.TabIndex = 25;
            chk_RestartOnUpdate_HTTP.Text = "Restart on Update";
            chk_RestartOnUpdate_HTTP.UseVisualStyleBackColor = true;
            // 
            // btn_Start_HTTP
            // 
            btn_Start_HTTP.Location = new Point(129, 225);
            btn_Start_HTTP.Name = "btn_Start_HTTP";
            btn_Start_HTTP.Size = new Size(114, 30);
            btn_Start_HTTP.TabIndex = 17;
            btn_Start_HTTP.Text = "Start";
            btn_Start_HTTP.UseVisualStyleBackColor = true;
            btn_Start_HTTP.Click += btn_Start_HTTP_Click;
            // 
            // chk_ServeFirstLocal_HTTP
            // 
            chk_ServeFirstLocal_HTTP.AutoSize = true;
            chk_ServeFirstLocal_HTTP.Checked = true;
            chk_ServeFirstLocal_HTTP.CheckState = CheckState.Checked;
            chk_ServeFirstLocal_HTTP.Location = new Point(8, 167);
            chk_ServeFirstLocal_HTTP.Name = "chk_ServeFirstLocal_HTTP";
            chk_ServeFirstLocal_HTTP.Size = new Size(338, 23);
            chk_ServeFirstLocal_HTTP.TabIndex = 24;
            chk_ServeFirstLocal_HTTP.Text = "Serve first Local Files (before Embedded Resources)";
            chk_ServeFirstLocal_HTTP.UseVisualStyleBackColor = true;
            // 
            // btn_Update_HTTP
            // 
            btn_Update_HTTP.Location = new Point(8, 225);
            btn_Update_HTTP.Name = "btn_Update_HTTP";
            btn_Update_HTTP.Size = new Size(114, 30);
            btn_Update_HTTP.TabIndex = 16;
            btn_Update_HTTP.Text = "Update";
            btn_Update_HTTP.UseVisualStyleBackColor = true;
            btn_Update_HTTP.Click += btn_Update_HTTP_Click;
            // 
            // chk_AllowCORS_HTTP
            // 
            chk_AllowCORS_HTTP.AutoSize = true;
            chk_AllowCORS_HTTP.Checked = true;
            chk_AllowCORS_HTTP.CheckState = CheckState.Checked;
            chk_AllowCORS_HTTP.Location = new Point(8, 138);
            chk_AllowCORS_HTTP.Name = "chk_AllowCORS_HTTP";
            chk_AllowCORS_HTTP.Size = new Size(188, 23);
            chk_AllowCORS_HTTP.TabIndex = 23;
            chk_AllowCORS_HTTP.Text = "Allow Cross Origin (CORS)";
            chk_AllowCORS_HTTP.UseVisualStyleBackColor = true;
            // 
            // txt_MaxConnections_HTTP
            // 
            txt_MaxConnections_HTTP.Location = new Point(150, 98);
            txt_MaxConnections_HTTP.Name = "txt_MaxConnections_HTTP";
            txt_MaxConnections_HTTP.Size = new Size(203, 26);
            txt_MaxConnections_HTTP.TabIndex = 22;
            txt_MaxConnections_HTTP.Text = "10";
            // 
            // txt_BasePathLocal_HTTP
            // 
            txt_BasePathLocal_HTTP.Location = new Point(150, 63);
            txt_BasePathLocal_HTTP.Name = "txt_BasePathLocal_HTTP";
            txt_BasePathLocal_HTTP.Size = new Size(203, 26);
            txt_BasePathLocal_HTTP.TabIndex = 21;
            txt_BasePathLocal_HTTP.Text = "www";
            // 
            // txt_Port_HTTP
            // 
            txt_Port_HTTP.Location = new Point(150, 28);
            txt_Port_HTTP.Name = "txt_Port_HTTP";
            txt_Port_HTTP.Size = new Size(203, 26);
            txt_Port_HTTP.TabIndex = 20;
            txt_Port_HTTP.Text = "8080";
            // 
            // lbl_BasePathLocal_HTTP
            // 
            lbl_BasePathLocal_HTTP.AutoSize = true;
            lbl_BasePathLocal_HTTP.Location = new Point(46, 67);
            lbl_BasePathLocal_HTTP.Name = "lbl_BasePathLocal_HTTP";
            lbl_BasePathLocal_HTTP.Size = new Size(104, 19);
            lbl_BasePathLocal_HTTP.TabIndex = 19;
            lbl_BasePathLocal_HTTP.Text = "Base Path Local";
            // 
            // lbl_MaxConnections_HTTP
            // 
            lbl_MaxConnections_HTTP.AutoSize = true;
            lbl_MaxConnections_HTTP.Location = new Point(31, 101);
            lbl_MaxConnections_HTTP.Name = "lbl_MaxConnections_HTTP";
            lbl_MaxConnections_HTTP.Size = new Size(115, 19);
            lbl_MaxConnections_HTTP.TabIndex = 18;
            lbl_MaxConnections_HTTP.Text = "Max Connections";
            // 
            // lbl_Port_HTTP
            // 
            lbl_Port_HTTP.AutoSize = true;
            lbl_Port_HTTP.Location = new Point(109, 32);
            lbl_Port_HTTP.Name = "lbl_Port_HTTP";
            lbl_Port_HTTP.Size = new Size(34, 19);
            lbl_Port_HTTP.TabIndex = 17;
            lbl_Port_HTTP.Text = "Port";
            // 
            // grbx_WS
            // 
            grbx_WS.BackColor = Color.AntiqueWhite;
            grbx_WS.Controls.Add(btn_Stop_WS);
            grbx_WS.Controls.Add(btn_Start_WS);
            grbx_WS.Controls.Add(lbl_APIKey_WS);
            grbx_WS.Controls.Add(btn_Update_WS);
            grbx_WS.Controls.Add(txt_APIKey_WS);
            grbx_WS.Controls.Add(chk_RestartOnUpdate_WS);
            grbx_WS.Controls.Add(txt_MaxConnections_WS);
            grbx_WS.Controls.Add(txt_Port_WS);
            grbx_WS.Controls.Add(lbl_MaxConnections_WS);
            grbx_WS.Controls.Add(lbl_Port_WS);
            grbx_WS.Location = new Point(14, 296);
            grbx_WS.Margin = new Padding(3, 4, 3, 4);
            grbx_WS.Name = "grbx_WS";
            grbx_WS.Padding = new Padding(3, 4, 3, 4);
            grbx_WS.Size = new Size(376, 212);
            grbx_WS.TabIndex = 1;
            grbx_WS.TabStop = false;
            grbx_WS.Text = "WebSocket Server Settings";
            // 
            // btn_Stop_WS
            // 
            btn_Stop_WS.Location = new Point(250, 167);
            btn_Stop_WS.Name = "btn_Stop_WS";
            btn_Stop_WS.Size = new Size(114, 30);
            btn_Stop_WS.TabIndex = 18;
            btn_Stop_WS.Text = "Stop";
            btn_Stop_WS.UseVisualStyleBackColor = true;
            btn_Stop_WS.Click += btn_Stop_WS_Click;
            // 
            // btn_Start_WS
            // 
            btn_Start_WS.Location = new Point(129, 167);
            btn_Start_WS.Name = "btn_Start_WS";
            btn_Start_WS.Size = new Size(114, 30);
            btn_Start_WS.TabIndex = 17;
            btn_Start_WS.Text = "Start";
            btn_Start_WS.UseVisualStyleBackColor = true;
            btn_Start_WS.Click += btn_Start_WS_Click;
            // 
            // lbl_APIKey_WS
            // 
            lbl_APIKey_WS.AutoSize = true;
            lbl_APIKey_WS.Location = new Point(88, 100);
            lbl_APIKey_WS.Name = "lbl_APIKey_WS";
            lbl_APIKey_WS.Size = new Size(56, 19);
            lbl_APIKey_WS.TabIndex = 26;
            lbl_APIKey_WS.Text = "API Key";
            // 
            // btn_Update_WS
            // 
            btn_Update_WS.Location = new Point(8, 167);
            btn_Update_WS.Name = "btn_Update_WS";
            btn_Update_WS.Size = new Size(114, 30);
            btn_Update_WS.TabIndex = 16;
            btn_Update_WS.Text = "Update";
            btn_Update_WS.UseVisualStyleBackColor = true;
            btn_Update_WS.Click += btn_Update_WS_Click;
            // 
            // txt_APIKey_WS
            // 
            txt_APIKey_WS.Location = new Point(150, 96);
            txt_APIKey_WS.Name = "txt_APIKey_WS";
            txt_APIKey_WS.Size = new Size(203, 26);
            txt_APIKey_WS.TabIndex = 25;
            // 
            // chk_RestartOnUpdate_WS
            // 
            chk_RestartOnUpdate_WS.AutoSize = true;
            chk_RestartOnUpdate_WS.Checked = true;
            chk_RestartOnUpdate_WS.CheckState = CheckState.Checked;
            chk_RestartOnUpdate_WS.Location = new Point(8, 138);
            chk_RestartOnUpdate_WS.Name = "chk_RestartOnUpdate_WS";
            chk_RestartOnUpdate_WS.Size = new Size(140, 23);
            chk_RestartOnUpdate_WS.TabIndex = 24;
            chk_RestartOnUpdate_WS.Text = "Restart on Update";
            chk_RestartOnUpdate_WS.UseVisualStyleBackColor = true;
            // 
            // txt_MaxConnections_WS
            // 
            txt_MaxConnections_WS.Location = new Point(150, 61);
            txt_MaxConnections_WS.Name = "txt_MaxConnections_WS";
            txt_MaxConnections_WS.Size = new Size(203, 26);
            txt_MaxConnections_WS.TabIndex = 23;
            txt_MaxConnections_WS.Text = "10";
            // 
            // txt_Port_WS
            // 
            txt_Port_WS.Location = new Point(150, 27);
            txt_Port_WS.Name = "txt_Port_WS";
            txt_Port_WS.Size = new Size(203, 26);
            txt_Port_WS.TabIndex = 22;
            txt_Port_WS.Text = "8081";
            // 
            // lbl_MaxConnections_WS
            // 
            lbl_MaxConnections_WS.AutoSize = true;
            lbl_MaxConnections_WS.Location = new Point(33, 65);
            lbl_MaxConnections_WS.Name = "lbl_MaxConnections_WS";
            lbl_MaxConnections_WS.Size = new Size(115, 19);
            lbl_MaxConnections_WS.TabIndex = 21;
            lbl_MaxConnections_WS.Text = "Max Connections";
            // 
            // lbl_Port_WS
            // 
            lbl_Port_WS.AutoSize = true;
            lbl_Port_WS.Location = new Point(109, 29);
            lbl_Port_WS.Name = "lbl_Port_WS";
            lbl_Port_WS.Size = new Size(34, 19);
            lbl_Port_WS.TabIndex = 20;
            lbl_Port_WS.Text = "Port";
            // 
            // grbx_QuickTools
            // 
            grbx_QuickTools.BackColor = Color.Linen;
            grbx_QuickTools.Controls.Add(btn_Open_Browser);
            grbx_QuickTools.Controls.Add(btn_Start);
            grbx_QuickTools.Controls.Add(btn_Open_AppFolder);
            grbx_QuickTools.Controls.Add(btn_Open_LogViewer);
            grbx_QuickTools.Location = new Point(779, 15);
            grbx_QuickTools.Margin = new Padding(3, 4, 3, 4);
            grbx_QuickTools.Name = "grbx_QuickTools";
            grbx_QuickTools.Padding = new Padding(3, 4, 3, 4);
            grbx_QuickTools.Size = new Size(376, 120);
            grbx_QuickTools.TabIndex = 4;
            grbx_QuickTools.TabStop = false;
            grbx_QuickTools.Text = "Quick Tools";
            // 
            // btn_Open_Browser
            // 
            btn_Open_Browser.Location = new Point(249, 27);
            btn_Open_Browser.Name = "btn_Open_Browser";
            btn_Open_Browser.Size = new Size(114, 30);
            btn_Open_Browser.TabIndex = 21;
            btn_Open_Browser.Text = "Open Browser";
            btn_Open_Browser.UseVisualStyleBackColor = true;
            btn_Open_Browser.Click += btn_Open_Browser_Click;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(7, 67);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(357, 39);
            btn_Start.TabIndex = 20;
            btn_Start.Text = "START ALL!";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_Open_AppFolder
            // 
            btn_Open_AppFolder.Location = new Point(128, 28);
            btn_Open_AppFolder.Name = "btn_Open_AppFolder";
            btn_Open_AppFolder.Size = new Size(114, 30);
            btn_Open_AppFolder.TabIndex = 20;
            btn_Open_AppFolder.Text = "App Folder";
            btn_Open_AppFolder.UseVisualStyleBackColor = true;
            btn_Open_AppFolder.Click += btn_Open_AppFolder_Click;
            // 
            // btn_Open_LogViewer
            // 
            btn_Open_LogViewer.Location = new Point(7, 28);
            btn_Open_LogViewer.Name = "btn_Open_LogViewer";
            btn_Open_LogViewer.Size = new Size(114, 30);
            btn_Open_LogViewer.TabIndex = 19;
            btn_Open_LogViewer.Text = "Log Viewer";
            btn_Open_LogViewer.UseVisualStyleBackColor = true;
            btn_Open_LogViewer.Click += btn_Open_LogViewer_Click;
            // 
            // grbx_Status
            // 
            grbx_Status.BackColor = Color.Honeydew;
            grbx_Status.Controls.Add(chkLb_State);
            grbx_Status.Location = new Point(779, 143);
            grbx_Status.Margin = new Padding(3, 4, 3, 4);
            grbx_Status.Name = "grbx_Status";
            grbx_Status.Padding = new Padding(3, 4, 3, 4);
            grbx_Status.Size = new Size(376, 315);
            grbx_Status.TabIndex = 5;
            grbx_Status.TabStop = false;
            grbx_Status.Text = "Status";
            // 
            // chkLb_State
            // 
            chkLb_State.FormattingEnabled = true;
            chkLb_State.Items.AddRange(new object[] { "HTTP Server Started", "HTTP Server Running", "Websocket Server Started", "Websocket Server Running", "MQTT Connected", "SQLite Client Connected", "MySQL Client Connected", "Ready" });
            chkLb_State.Location = new Point(7, 27);
            chkLb_State.Margin = new Padding(3, 4, 3, 4);
            chkLb_State.Name = "chkLb_State";
            chkLb_State.Size = new Size(356, 277);
            chkLb_State.TabIndex = 22;
            // 
            // grbx_MQTT
            // 
            grbx_MQTT.BackColor = Color.Beige;
            grbx_MQTT.Controls.Add(lbl_TopicSubscribe_MQTT);
            grbx_MQTT.Controls.Add(lbl_TopicPublish_Topic_MQTT);
            grbx_MQTT.Controls.Add(lbl_TopicPublish_Payload_MQTT);
            grbx_MQTT.Controls.Add(txt_TopicPublish_Payload_MQTT);
            grbx_MQTT.Controls.Add(btn_TopicPublish_MQTT);
            grbx_MQTT.Controls.Add(txt_TopicPublish_Topic_MQTT);
            grbx_MQTT.Controls.Add(btn_TopicSubscribe_MQTT);
            grbx_MQTT.Controls.Add(txt_TopicSubscribe_MQTT);
            grbx_MQTT.Controls.Add(chk_RestartOnUpdate_MQTT);
            grbx_MQTT.Controls.Add(btn_Stop_MQTT);
            grbx_MQTT.Controls.Add(btn_Start_MQTT);
            grbx_MQTT.Controls.Add(txt_Password_MQTT);
            grbx_MQTT.Controls.Add(btn_Update_MQTT);
            grbx_MQTT.Controls.Add(txt_Username_MQTT);
            grbx_MQTT.Controls.Add(lbl_Username_MQTT);
            grbx_MQTT.Controls.Add(lbl_Password_MQTT);
            grbx_MQTT.Controls.Add(txt_Port_MQTT);
            grbx_MQTT.Controls.Add(txt_Host_MQTT);
            grbx_MQTT.Controls.Add(lbl_Host_MQTT);
            grbx_MQTT.Controls.Add(lbl_Port_MQTT);
            grbx_MQTT.Location = new Point(14, 516);
            grbx_MQTT.Margin = new Padding(3, 4, 3, 4);
            grbx_MQTT.Name = "grbx_MQTT";
            grbx_MQTT.Padding = new Padding(3, 4, 3, 4);
            grbx_MQTT.Size = new Size(376, 388);
            grbx_MQTT.TabIndex = 6;
            grbx_MQTT.TabStop = false;
            grbx_MQTT.Text = "MQTT Client Settings";
            // 
            // lbl_TopicSubscribe_MQTT
            // 
            lbl_TopicSubscribe_MQTT.AutoSize = true;
            lbl_TopicSubscribe_MQTT.Location = new Point(31, 266);
            lbl_TopicSubscribe_MQTT.Name = "lbl_TopicSubscribe_MQTT";
            lbl_TopicSubscribe_MQTT.Size = new Size(40, 19);
            lbl_TopicSubscribe_MQTT.TabIndex = 39;
            lbl_TopicSubscribe_MQTT.Text = "Topic";
            // 
            // lbl_TopicPublish_Topic_MQTT
            // 
            lbl_TopicPublish_Topic_MQTT.AutoSize = true;
            lbl_TopicPublish_Topic_MQTT.Location = new Point(26, 317);
            lbl_TopicPublish_Topic_MQTT.Name = "lbl_TopicPublish_Topic_MQTT";
            lbl_TopicPublish_Topic_MQTT.Size = new Size(40, 19);
            lbl_TopicPublish_Topic_MQTT.TabIndex = 37;
            lbl_TopicPublish_Topic_MQTT.Text = "Topic";
            // 
            // lbl_TopicPublish_Payload_MQTT
            // 
            lbl_TopicPublish_Payload_MQTT.AutoSize = true;
            lbl_TopicPublish_Payload_MQTT.Location = new Point(10, 351);
            lbl_TopicPublish_Payload_MQTT.Name = "lbl_TopicPublish_Payload_MQTT";
            lbl_TopicPublish_Payload_MQTT.Size = new Size(57, 19);
            lbl_TopicPublish_Payload_MQTT.TabIndex = 38;
            lbl_TopicPublish_Payload_MQTT.Text = "Payload";
            // 
            // txt_TopicPublish_Payload_MQTT
            // 
            txt_TopicPublish_Payload_MQTT.Location = new Point(73, 347);
            txt_TopicPublish_Payload_MQTT.Name = "txt_TopicPublish_Payload_MQTT";
            txt_TopicPublish_Payload_MQTT.Size = new Size(206, 26);
            txt_TopicPublish_Payload_MQTT.TabIndex = 36;
            // 
            // btn_TopicPublish_MQTT
            // 
            btn_TopicPublish_MQTT.Location = new Point(287, 313);
            btn_TopicPublish_MQTT.Name = "btn_TopicPublish_MQTT";
            btn_TopicPublish_MQTT.Size = new Size(78, 65);
            btn_TopicPublish_MQTT.TabIndex = 35;
            btn_TopicPublish_MQTT.Text = "Publish";
            btn_TopicPublish_MQTT.UseVisualStyleBackColor = true;
            btn_TopicPublish_MQTT.Click += btn_TopicPublish_MQTT_Click;
            // 
            // txt_TopicPublish_Topic_MQTT
            // 
            txt_TopicPublish_Topic_MQTT.Location = new Point(73, 313);
            txt_TopicPublish_Topic_MQTT.Name = "txt_TopicPublish_Topic_MQTT";
            txt_TopicPublish_Topic_MQTT.Size = new Size(206, 26);
            txt_TopicPublish_Topic_MQTT.TabIndex = 34;
            // 
            // btn_TopicSubscribe_MQTT
            // 
            btn_TopicSubscribe_MQTT.Location = new Point(287, 260);
            btn_TopicSubscribe_MQTT.Name = "btn_TopicSubscribe_MQTT";
            btn_TopicSubscribe_MQTT.Size = new Size(78, 30);
            btn_TopicSubscribe_MQTT.TabIndex = 32;
            btn_TopicSubscribe_MQTT.Text = "Subscribe";
            btn_TopicSubscribe_MQTT.UseVisualStyleBackColor = true;
            btn_TopicSubscribe_MQTT.Click += btn_TopicSubscribe_MQTT_Click;
            // 
            // txt_TopicSubscribe_MQTT
            // 
            txt_TopicSubscribe_MQTT.Location = new Point(73, 260);
            txt_TopicSubscribe_MQTT.Name = "txt_TopicSubscribe_MQTT";
            txt_TopicSubscribe_MQTT.Size = new Size(206, 26);
            txt_TopicSubscribe_MQTT.TabIndex = 31;
            // 
            // chk_RestartOnUpdate_MQTT
            // 
            chk_RestartOnUpdate_MQTT.AutoSize = true;
            chk_RestartOnUpdate_MQTT.Checked = true;
            chk_RestartOnUpdate_MQTT.CheckState = CheckState.Checked;
            chk_RestartOnUpdate_MQTT.Location = new Point(10, 176);
            chk_RestartOnUpdate_MQTT.Name = "chk_RestartOnUpdate_MQTT";
            chk_RestartOnUpdate_MQTT.Size = new Size(140, 23);
            chk_RestartOnUpdate_MQTT.TabIndex = 25;
            chk_RestartOnUpdate_MQTT.Text = "Restart on Update";
            chk_RestartOnUpdate_MQTT.UseVisualStyleBackColor = true;
            // 
            // btn_Stop_MQTT
            // 
            btn_Stop_MQTT.Location = new Point(250, 205);
            btn_Stop_MQTT.Name = "btn_Stop_MQTT";
            btn_Stop_MQTT.Size = new Size(114, 30);
            btn_Stop_MQTT.TabIndex = 29;
            btn_Stop_MQTT.Text = "Stop";
            btn_Stop_MQTT.UseVisualStyleBackColor = true;
            btn_Stop_MQTT.Click += btn_Stop_MQTT_Click;
            // 
            // btn_Start_MQTT
            // 
            btn_Start_MQTT.Location = new Point(129, 205);
            btn_Start_MQTT.Name = "btn_Start_MQTT";
            btn_Start_MQTT.Size = new Size(114, 30);
            btn_Start_MQTT.TabIndex = 28;
            btn_Start_MQTT.Text = "Start";
            btn_Start_MQTT.UseVisualStyleBackColor = true;
            btn_Start_MQTT.Click += btn_Start_MQTT_Click;
            // 
            // txt_Password_MQTT
            // 
            txt_Password_MQTT.Location = new Point(150, 137);
            txt_Password_MQTT.Name = "txt_Password_MQTT";
            txt_Password_MQTT.Size = new Size(203, 26);
            txt_Password_MQTT.TabIndex = 29;
            // 
            // btn_Update_MQTT
            // 
            btn_Update_MQTT.Location = new Point(8, 205);
            btn_Update_MQTT.Name = "btn_Update_MQTT";
            btn_Update_MQTT.Size = new Size(114, 30);
            btn_Update_MQTT.TabIndex = 27;
            btn_Update_MQTT.Text = "Update";
            btn_Update_MQTT.UseVisualStyleBackColor = true;
            btn_Update_MQTT.Click += btn_Update_MQTT_Click;
            // 
            // txt_Username_MQTT
            // 
            txt_Username_MQTT.Location = new Point(150, 101);
            txt_Username_MQTT.Name = "txt_Username_MQTT";
            txt_Username_MQTT.Size = new Size(203, 26);
            txt_Username_MQTT.TabIndex = 28;
            // 
            // lbl_Username_MQTT
            // 
            lbl_Username_MQTT.AutoSize = true;
            lbl_Username_MQTT.Location = new Point(73, 105);
            lbl_Username_MQTT.Name = "lbl_Username_MQTT";
            lbl_Username_MQTT.Size = new Size(71, 19);
            lbl_Username_MQTT.TabIndex = 26;
            lbl_Username_MQTT.Text = "Username";
            // 
            // lbl_Password_MQTT
            // 
            lbl_Password_MQTT.AutoSize = true;
            lbl_Password_MQTT.Location = new Point(77, 141);
            lbl_Password_MQTT.Name = "lbl_Password_MQTT";
            lbl_Password_MQTT.Size = new Size(67, 19);
            lbl_Password_MQTT.TabIndex = 27;
            lbl_Password_MQTT.Text = "Password";
            // 
            // txt_Port_MQTT
            // 
            txt_Port_MQTT.Location = new Point(150, 62);
            txt_Port_MQTT.Name = "txt_Port_MQTT";
            txt_Port_MQTT.Size = new Size(203, 26);
            txt_Port_MQTT.TabIndex = 25;
            txt_Port_MQTT.Text = "1883";
            // 
            // txt_Host_MQTT
            // 
            txt_Host_MQTT.Location = new Point(150, 27);
            txt_Host_MQTT.Name = "txt_Host_MQTT";
            txt_Host_MQTT.Size = new Size(203, 26);
            txt_Host_MQTT.TabIndex = 24;
            txt_Host_MQTT.Text = "localhost";
            // 
            // lbl_Host_MQTT
            // 
            lbl_Host_MQTT.AutoSize = true;
            lbl_Host_MQTT.Location = new Point(109, 30);
            lbl_Host_MQTT.Name = "lbl_Host_MQTT";
            lbl_Host_MQTT.Size = new Size(38, 19);
            lbl_Host_MQTT.TabIndex = 22;
            lbl_Host_MQTT.Text = "Host";
            // 
            // lbl_Port_MQTT
            // 
            lbl_Port_MQTT.AutoSize = true;
            lbl_Port_MQTT.Location = new Point(109, 66);
            lbl_Port_MQTT.Name = "lbl_Port_MQTT";
            lbl_Port_MQTT.Size = new Size(34, 19);
            lbl_Port_MQTT.TabIndex = 23;
            lbl_Port_MQTT.Text = "Port";
            // 
            // grbx_SQLite
            // 
            grbx_SQLite.BackColor = Color.AliceBlue;
            grbx_SQLite.Controls.Add(chk_RestartOnUpdate_SQLite);
            grbx_SQLite.Controls.Add(btn_Disconnect_SQLite);
            grbx_SQLite.Controls.Add(btn_Connect_SQLite);
            grbx_SQLite.Controls.Add(btn_Update_SQLite);
            grbx_SQLite.Controls.Add(txt_Server_SQLite);
            grbx_SQLite.Controls.Add(lbl_Server_SQLite);
            grbx_SQLite.Location = new Point(397, 15);
            grbx_SQLite.Margin = new Padding(3, 4, 3, 4);
            grbx_SQLite.Name = "grbx_SQLite";
            grbx_SQLite.Padding = new Padding(3, 4, 3, 4);
            grbx_SQLite.Size = new Size(376, 133);
            grbx_SQLite.TabIndex = 7;
            grbx_SQLite.TabStop = false;
            grbx_SQLite.Text = "SQLite Client Settings";
            // 
            // chk_RestartOnUpdate_SQLite
            // 
            chk_RestartOnUpdate_SQLite.AutoSize = true;
            chk_RestartOnUpdate_SQLite.Checked = true;
            chk_RestartOnUpdate_SQLite.CheckState = CheckState.Checked;
            chk_RestartOnUpdate_SQLite.Location = new Point(12, 61);
            chk_RestartOnUpdate_SQLite.Name = "chk_RestartOnUpdate_SQLite";
            chk_RestartOnUpdate_SQLite.Size = new Size(140, 23);
            chk_RestartOnUpdate_SQLite.TabIndex = 25;
            chk_RestartOnUpdate_SQLite.Text = "Restart on Update";
            chk_RestartOnUpdate_SQLite.UseVisualStyleBackColor = true;
            // 
            // btn_Disconnect_SQLite
            // 
            btn_Disconnect_SQLite.Location = new Point(252, 89);
            btn_Disconnect_SQLite.Name = "btn_Disconnect_SQLite";
            btn_Disconnect_SQLite.Size = new Size(114, 30);
            btn_Disconnect_SQLite.TabIndex = 29;
            btn_Disconnect_SQLite.Text = "Disconnect";
            btn_Disconnect_SQLite.UseVisualStyleBackColor = true;
            btn_Disconnect_SQLite.Click += btn_Disconnect_SQLite_Click;
            // 
            // btn_Connect_SQLite
            // 
            btn_Connect_SQLite.Location = new Point(131, 89);
            btn_Connect_SQLite.Name = "btn_Connect_SQLite";
            btn_Connect_SQLite.Size = new Size(114, 30);
            btn_Connect_SQLite.TabIndex = 28;
            btn_Connect_SQLite.Text = "Connect";
            btn_Connect_SQLite.UseVisualStyleBackColor = true;
            btn_Connect_SQLite.Click += btn_Connect_SQLite_Click;
            // 
            // btn_Update_SQLite
            // 
            btn_Update_SQLite.Location = new Point(10, 89);
            btn_Update_SQLite.Name = "btn_Update_SQLite";
            btn_Update_SQLite.Size = new Size(114, 30);
            btn_Update_SQLite.TabIndex = 27;
            btn_Update_SQLite.Text = "Update";
            btn_Update_SQLite.UseVisualStyleBackColor = true;
            btn_Update_SQLite.Click += btn_Update_SQLite_Click;
            // 
            // txt_Server_SQLite
            // 
            txt_Server_SQLite.Location = new Point(150, 27);
            txt_Server_SQLite.Name = "txt_Server_SQLite";
            txt_Server_SQLite.Size = new Size(203, 26);
            txt_Server_SQLite.TabIndex = 24;
            txt_Server_SQLite.Text = "database.db";
            // 
            // lbl_Server_SQLite
            // 
            lbl_Server_SQLite.AutoSize = true;
            lbl_Server_SQLite.Location = new Point(97, 30);
            lbl_Server_SQLite.Name = "lbl_Server_SQLite";
            lbl_Server_SQLite.Size = new Size(47, 19);
            lbl_Server_SQLite.TabIndex = 22;
            lbl_Server_SQLite.Text = "Server";
            // 
            // grbx_MySQL
            // 
            grbx_MySQL.BackColor = Color.Lavender;
            grbx_MySQL.Controls.Add(txt_Database_MySQL);
            grbx_MySQL.Controls.Add(lbl_Database_MySQL);
            grbx_MySQL.Controls.Add(chk_RestartOnUpdate_MySQL);
            grbx_MySQL.Controls.Add(btn_Disconnect_MySQL);
            grbx_MySQL.Controls.Add(btn_Connect_MySQL);
            grbx_MySQL.Controls.Add(txt_Password_MySQL);
            grbx_MySQL.Controls.Add(btn_Update_MySQL);
            grbx_MySQL.Controls.Add(txt_Username_MySQL);
            grbx_MySQL.Controls.Add(lbl_Username_MySQL);
            grbx_MySQL.Controls.Add(lbl_Password_MySQL);
            grbx_MySQL.Controls.Add(txt_Port_MySQL);
            grbx_MySQL.Controls.Add(txt_Server_MySQL);
            grbx_MySQL.Controls.Add(lbl_Server_MySQL);
            grbx_MySQL.Controls.Add(lbl_Port_MySQL);
            grbx_MySQL.Location = new Point(397, 156);
            grbx_MySQL.Margin = new Padding(3, 4, 3, 4);
            grbx_MySQL.Name = "grbx_MySQL";
            grbx_MySQL.Padding = new Padding(3, 4, 3, 4);
            grbx_MySQL.Size = new Size(376, 285);
            grbx_MySQL.TabIndex = 8;
            grbx_MySQL.TabStop = false;
            grbx_MySQL.Text = "MySQL Client Settings";
            // 
            // txt_Database_MySQL
            // 
            txt_Database_MySQL.Location = new Point(150, 175);
            txt_Database_MySQL.Name = "txt_Database_MySQL";
            txt_Database_MySQL.Size = new Size(203, 26);
            txt_Database_MySQL.TabIndex = 31;
            // 
            // lbl_Database_MySQL
            // 
            lbl_Database_MySQL.AutoSize = true;
            lbl_Database_MySQL.Location = new Point(78, 179);
            lbl_Database_MySQL.Name = "lbl_Database_MySQL";
            lbl_Database_MySQL.Size = new Size(66, 19);
            lbl_Database_MySQL.TabIndex = 30;
            lbl_Database_MySQL.Text = "Database";
            // 
            // chk_RestartOnUpdate_MySQL
            // 
            chk_RestartOnUpdate_MySQL.AutoSize = true;
            chk_RestartOnUpdate_MySQL.Checked = true;
            chk_RestartOnUpdate_MySQL.CheckState = CheckState.Checked;
            chk_RestartOnUpdate_MySQL.Location = new Point(12, 210);
            chk_RestartOnUpdate_MySQL.Name = "chk_RestartOnUpdate_MySQL";
            chk_RestartOnUpdate_MySQL.Size = new Size(140, 23);
            chk_RestartOnUpdate_MySQL.TabIndex = 25;
            chk_RestartOnUpdate_MySQL.Text = "Restart on Update";
            chk_RestartOnUpdate_MySQL.UseVisualStyleBackColor = true;
            // 
            // btn_Disconnect_MySQL
            // 
            btn_Disconnect_MySQL.Location = new Point(252, 237);
            btn_Disconnect_MySQL.Name = "btn_Disconnect_MySQL";
            btn_Disconnect_MySQL.Size = new Size(114, 30);
            btn_Disconnect_MySQL.TabIndex = 29;
            btn_Disconnect_MySQL.Text = "Disconnect";
            btn_Disconnect_MySQL.UseVisualStyleBackColor = true;
            btn_Disconnect_MySQL.Click += btn_Disconnect_MySQL_Click;
            // 
            // btn_Connect_MySQL
            // 
            btn_Connect_MySQL.Location = new Point(131, 237);
            btn_Connect_MySQL.Name = "btn_Connect_MySQL";
            btn_Connect_MySQL.Size = new Size(114, 30);
            btn_Connect_MySQL.TabIndex = 28;
            btn_Connect_MySQL.Text = "Connect";
            btn_Connect_MySQL.UseVisualStyleBackColor = true;
            btn_Connect_MySQL.Click += btn_Connect_MySQL_Click;
            // 
            // txt_Password_MySQL
            // 
            txt_Password_MySQL.Location = new Point(150, 137);
            txt_Password_MySQL.Name = "txt_Password_MySQL";
            txt_Password_MySQL.Size = new Size(203, 26);
            txt_Password_MySQL.TabIndex = 29;
            // 
            // btn_Update_MySQL
            // 
            btn_Update_MySQL.Location = new Point(10, 237);
            btn_Update_MySQL.Name = "btn_Update_MySQL";
            btn_Update_MySQL.Size = new Size(114, 30);
            btn_Update_MySQL.TabIndex = 27;
            btn_Update_MySQL.Text = "Update";
            btn_Update_MySQL.UseVisualStyleBackColor = true;
            btn_Update_MySQL.Click += btn_Update_MySQL_Click;
            // 
            // txt_Username_MySQL
            // 
            txt_Username_MySQL.Location = new Point(150, 101);
            txt_Username_MySQL.Name = "txt_Username_MySQL";
            txt_Username_MySQL.Size = new Size(203, 26);
            txt_Username_MySQL.TabIndex = 28;
            txt_Username_MySQL.Text = "root";
            // 
            // lbl_Username_MySQL
            // 
            lbl_Username_MySQL.AutoSize = true;
            lbl_Username_MySQL.Location = new Point(73, 107);
            lbl_Username_MySQL.Name = "lbl_Username_MySQL";
            lbl_Username_MySQL.Size = new Size(71, 19);
            lbl_Username_MySQL.TabIndex = 26;
            lbl_Username_MySQL.Text = "Username";
            // 
            // lbl_Password_MySQL
            // 
            lbl_Password_MySQL.AutoSize = true;
            lbl_Password_MySQL.Location = new Point(77, 143);
            lbl_Password_MySQL.Name = "lbl_Password_MySQL";
            lbl_Password_MySQL.Size = new Size(67, 19);
            lbl_Password_MySQL.TabIndex = 27;
            lbl_Password_MySQL.Text = "Password";
            // 
            // txt_Port_MySQL
            // 
            txt_Port_MySQL.Location = new Point(150, 62);
            txt_Port_MySQL.Name = "txt_Port_MySQL";
            txt_Port_MySQL.Size = new Size(203, 26);
            txt_Port_MySQL.TabIndex = 25;
            txt_Port_MySQL.Text = "3306";
            // 
            // txt_Server_MySQL
            // 
            txt_Server_MySQL.Location = new Point(150, 27);
            txt_Server_MySQL.Name = "txt_Server_MySQL";
            txt_Server_MySQL.Size = new Size(203, 26);
            txt_Server_MySQL.TabIndex = 24;
            txt_Server_MySQL.Text = "localhost";
            // 
            // lbl_Server_MySQL
            // 
            lbl_Server_MySQL.AutoSize = true;
            lbl_Server_MySQL.Location = new Point(97, 31);
            lbl_Server_MySQL.Name = "lbl_Server_MySQL";
            lbl_Server_MySQL.Size = new Size(47, 19);
            lbl_Server_MySQL.TabIndex = 22;
            lbl_Server_MySQL.Text = "Server";
            // 
            // lbl_Port_MySQL
            // 
            lbl_Port_MySQL.AutoSize = true;
            lbl_Port_MySQL.Location = new Point(110, 66);
            lbl_Port_MySQL.Name = "lbl_Port_MySQL";
            lbl_Port_MySQL.Size = new Size(34, 19);
            lbl_Port_MySQL.TabIndex = 23;
            lbl_Port_MySQL.Text = "Port";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 915);
            Controls.Add(grbx_MySQL);
            Controls.Add(grbx_SQLite);
            Controls.Add(grbx_MQTT);
            Controls.Add(grbx_Status);
            Controls.Add(grbx_QuickTools);
            Controls.Add(grbx_WS);
            Controls.Add(grbx_HTTP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Glitcher Core Lib - Demo App";
            grbx_HTTP.ResumeLayout(false);
            grbx_HTTP.PerformLayout();
            grbx_WS.ResumeLayout(false);
            grbx_WS.PerformLayout();
            grbx_QuickTools.ResumeLayout(false);
            grbx_Status.ResumeLayout(false);
            grbx_MQTT.ResumeLayout(false);
            grbx_MQTT.PerformLayout();
            grbx_SQLite.ResumeLayout(false);
            grbx_SQLite.PerformLayout();
            grbx_MySQL.ResumeLayout(false);
            grbx_MySQL.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbx_HTTP;
        private CheckBox chk_RestartOnUpdate_HTTP;
        private CheckBox chk_ServeFirstLocal_HTTP;
        private CheckBox chk_AllowCORS_HTTP;
        private TextBox txt_MaxConnections_HTTP;
        private TextBox txt_BasePathLocal_HTTP;
        private TextBox txt_Port_HTTP;
        private Label lbl_BasePathLocal_HTTP;
        private Label lbl_MaxConnections_HTTP;
        private Label lbl_Port_HTTP;
        private GroupBox grbx_WS;
        private Button btn_Stop_HTTP;
        private Button btn_Start_HTTP;
        private Button btn_Update_HTTP;
        private Button btn_Stop_WS;
        private Button btn_Start_WS;
        private Label lbl_APIKey_WS;
        private Button btn_Update_WS;
        private TextBox txt_APIKey_WS;
        private CheckBox chk_RestartOnUpdate_WS;
        private TextBox txt_MaxConnections_WS;
        private TextBox txt_Port_WS;
        private Label lbl_MaxConnections_WS;
        private Label lbl_Port_WS;
        private GroupBox grbx_QuickTools;
        private Button btn_Open_Browser;
        private Button btn_Open_AppFolder;
        private Button btn_Open_LogViewer;
        private GroupBox grbx_Status;
        private CheckedListBox chkLb_State;
        private Button btn_Start;
        private GroupBox grbx_MQTT;
        private CheckBox chk_RestartOnUpdate_MQTT;
        private Button btn_Stop_MQTT;
        private Button btn_Start_MQTT;
        private TextBox txt_Password_MQTT;
        private Button btn_Update_MQTT;
        private TextBox txt_Username_MQTT;
        private Label lbl_Username_MQTT;
        private Label lbl_Password_MQTT;
        private TextBox txt_Port_MQTT;
        private TextBox txt_Host_MQTT;
        private Label lbl_Host_MQTT;
        private Label lbl_Port_MQTT;
        private Button btn_TopicSubscribe_MQTT;
        private TextBox txt_TopicSubscribe_MQTT;
        private Label lbl_TopicSubscribe_MQTT;
        private Label lbl_TopicPublish_Topic_MQTT;
        private Label lbl_TopicPublish_Payload_MQTT;
        private TextBox txt_TopicPublish_Payload_MQTT;
        private Button btn_TopicPublish_MQTT;
        private TextBox txt_TopicPublish_Topic_MQTT;
        private GroupBox grbx_SQLite;
        private CheckBox chk_RestartOnUpdate_SQLite;
        private Button btn_Disconnect_SQLite;
        private Button btn_Connect_SQLite;
        private Button btn_Update_SQLite;
        private TextBox txt_Server_SQLite;
        private Label lbl_Server_SQLite;
        private GroupBox grbx_MySQL;
        private TextBox txt_Database_MySQL;
        private Label lbl_Database_MySQL;
        private CheckBox chk_RestartOnUpdate_MySQL;
        private Button btn_Disconnect_MySQL;
        private Button btn_Connect_MySQL;
        private TextBox txt_Password_MySQL;
        private Button btn_Update_MySQL;
        private TextBox txt_Username_MySQL;
        private Label lbl_Username_MySQL;
        private Label lbl_Password_MySQL;
        private TextBox txt_Port_MySQL;
        private TextBox txt_Server_MySQL;
        private Label lbl_Server_MySQL;
        private Label lbl_Port_MySQL;
    }
}
