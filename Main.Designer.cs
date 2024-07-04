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
            btn_Open_AppFolder = new Button();
            btn_Open_LogViewer = new Button();
            grbx_Status = new GroupBox();
            chkLb_State = new CheckedListBox();
            btn_Start = new Button();
            grbx_HTTP.SuspendLayout();
            grbx_WS.SuspendLayout();
            grbx_QuickTools.SuspendLayout();
            grbx_Status.SuspendLayout();
            SuspendLayout();
            // 
            // grbx_HTTP
            // 
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
            grbx_QuickTools.Controls.Add(btn_Open_Browser);
            grbx_QuickTools.Controls.Add(btn_Start);
            grbx_QuickTools.Controls.Add(btn_Open_AppFolder);
            grbx_QuickTools.Controls.Add(btn_Open_LogViewer);
            grbx_QuickTools.Location = new Point(397, 15);
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
            grbx_Status.Controls.Add(chkLb_State);
            grbx_Status.Location = new Point(397, 143);
            grbx_Status.Margin = new Padding(3, 4, 3, 4);
            grbx_Status.Name = "grbx_Status";
            grbx_Status.Padding = new Padding(3, 4, 3, 4);
            grbx_Status.Size = new Size(374, 365);
            grbx_Status.TabIndex = 5;
            grbx_Status.TabStop = false;
            grbx_Status.Text = "Status";
            // 
            // chkLb_State
            // 
            chkLb_State.FormattingEnabled = true;
            chkLb_State.Items.AddRange(new object[] { "HTTP Server Started", "HTTP Server Running", "Websocket Server Started", "Websocket Server Running", "Ready" });
            chkLb_State.Location = new Point(7, 27);
            chkLb_State.Margin = new Padding(3, 4, 3, 4);
            chkLb_State.Name = "chkLb_State";
            chkLb_State.Size = new Size(356, 319);
            chkLb_State.TabIndex = 22;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(7, 67);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(356, 39);
            btn_Start.TabIndex = 20;
            btn_Start.Text = "START ALL!";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 519);
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
    }
}
