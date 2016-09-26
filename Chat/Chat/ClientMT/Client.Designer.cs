namespace ClientMT
{
    partial class frmClient
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenuConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuCredits = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.lsbListMessage = new System.Windows.Forms.ListBox();
            this.tabChat = new System.Windows.Forms.TabControl();
            this.lsbListUsers = new System.Windows.Forms.ListBox();
            this.MainMenu.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuConnection,
            this.MainMenuSettings,
            this.MainMenuCredits});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(984, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Menu";
            // 
            // MainMenuConnection
            // 
            this.MainMenuConnection.Name = "MainMenuConnection";
            this.MainMenuConnection.Size = new System.Drawing.Size(81, 20);
            this.MainMenuConnection.Text = "Connection";
            this.MainMenuConnection.Click += new System.EventHandler(this.MainMenuConnection_Click);
            // 
            // MainMenuSettings
            // 
            this.MainMenuSettings.Name = "MainMenuSettings";
            this.MainMenuSettings.Size = new System.Drawing.Size(61, 20);
            this.MainMenuSettings.Text = "Settings";
            this.MainMenuSettings.Click += new System.EventHandler(this.MainMenuSettings_Click);
            // 
            // MainMenuCredits
            // 
            this.MainMenuCredits.Name = "MainMenuCredits";
            this.MainMenuCredits.Size = new System.Drawing.Size(56, 20);
            this.MainMenuCredits.Text = "Credits";
            this.MainMenuCredits.Click += new System.EventHandler(this.MainMenuCredits_Click);
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(12, 525);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(520, 20);
            this.tbxMessage.TabIndex = 2;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(539, 524);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 23);
            this.btnSendMessage.TabIndex = 3;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.lsbListMessage);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(594, 469);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // lsbListMessage
            // 
            this.lsbListMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbListMessage.FormattingEnabled = true;
            this.lsbListMessage.Location = new System.Drawing.Point(3, 3);
            this.lsbListMessage.Name = "lsbListMessage";
            this.lsbListMessage.Size = new System.Drawing.Size(588, 463);
            this.lsbListMessage.TabIndex = 0;
            // 
            // tabChat
            // 
            this.tabChat.Controls.Add(this.tabMain);
            this.tabChat.Location = new System.Drawing.Point(12, 27);
            this.tabChat.Name = "tabChat";
            this.tabChat.SelectedIndex = 0;
            this.tabChat.Size = new System.Drawing.Size(602, 495);
            this.tabChat.TabIndex = 1;
            // 
            // lsbListUsers
            // 
            this.lsbListUsers.FormattingEnabled = true;
            this.lsbListUsers.Location = new System.Drawing.Point(735, 49);
            this.lsbListUsers.Name = "lsbListUsers";
            this.lsbListUsers.Size = new System.Drawing.Size(237, 459);
            this.lsbListUsers.TabIndex = 4;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lsbListUsers);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tabChat);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabChat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem MainMenuCredits;
        private System.Windows.Forms.ToolStripMenuItem MainMenuConnection;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.ListBox lsbListUsers;
        public System.Windows.Forms.ListBox lsbListMessage;
        public System.Windows.Forms.TabControl tabChat;
    }
}

