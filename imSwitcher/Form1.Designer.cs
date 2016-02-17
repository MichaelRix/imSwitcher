namespace imSwitcher
{
    partial class Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SiteLink = new System.Windows.Forms.LinkLabel();
            this.Settings = new System.Windows.Forms.CheckedListBox();
            this.NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Notify
            // 
            this.Notify.ContextMenuStrip = this.NotifyMenu;
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "MSPY - CHT";
            this.Notify.Visible = true;
            this.Notify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Notify_MouseClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.NotifyMenu.Size = new System.Drawing.Size(122, 76);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.showToolStripMenuItem.Text = "顯示(&S)";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.aboutToolStripMenuItem.Text = "關於(&A)";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.exitToolStripMenuItem.Text = "退出(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SiteLink
            // 
            this.SiteLink.AutoSize = true;
            this.SiteLink.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SiteLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.SiteLink.Location = new System.Drawing.Point(14, 149);
            this.SiteLink.Name = "SiteLink";
            this.SiteLink.Size = new System.Drawing.Size(149, 17);
            this.SiteLink.TabIndex = 1;
            this.SiteLink.TabStop = true;
            this.SiteLink.Text = "https://www.nottres.com";
            this.SiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SiteLink_LinkClicked);
            // 
            // Settings
            // 
            this.Settings.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Settings.FormattingEnabled = true;
            this.Settings.Items.AddRange(new object[] {
            "自動修正",
            "雲端候選項",
            "模糊拼音",
            "自學習"});
            this.Settings.Location = new System.Drawing.Point(17, 17);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(301, 104);
            this.Settings.TabIndex = 2;
            this.Settings.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Settings_ItemCheck);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 178);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.SiteLink);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.ShowInTaskbar = false;
            this.Text = "imSwitcher VERSION1.1.1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.LinkLabel SiteLink;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox Settings;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

