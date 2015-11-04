namespace AnimeManagementSystem.View
{
    partial class AnimeManagementSystemForm
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPage = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPageNew = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPageFollowing = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPageEnded = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPageDispose = new System.Windows.Forms.ToolStripMenuItem();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._newPage = new System.Windows.Forms.TabPage();
            this._followingPage = new System.Windows.Forms.TabPage();
            this._endedPage = new System.Windows.Forms.TabPage();
            this._disposePage = new System.Windows.Forms.TabPage();
            this._animeListBox = new AnimeManagementSystem.View.UserControls.AnimeListBox();
            this._menuStrip.SuspendLayout();
            this._tabControl.SuspendLayout();
            this._newPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemFile,
            this._menuItemPage});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(784, 28);
            this._menuStrip.TabIndex = 1;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _menuItemFile
            // 
            this._menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemFileImport,
            this._menuItemFileExport,
            this._menuItemFileExit});
            this._menuItemFile.Name = "_menuItemFile";
            this._menuItemFile.Size = new System.Drawing.Size(53, 24);
            this._menuItemFile.Text = "檔案";
            // 
            // _menuItemFileImport
            // 
            this._menuItemFileImport.Name = "_menuItemFileImport";
            this._menuItemFileImport.Size = new System.Drawing.Size(110, 24);
            this._menuItemFileImport.Text = "匯入";
            // 
            // _menuItemFileExport
            // 
            this._menuItemFileExport.Name = "_menuItemFileExport";
            this._menuItemFileExport.Size = new System.Drawing.Size(110, 24);
            this._menuItemFileExport.Text = "匯出";
            // 
            // _menuItemFileExit
            // 
            this._menuItemFileExit.Name = "_menuItemFileExit";
            this._menuItemFileExit.Size = new System.Drawing.Size(110, 24);
            this._menuItemFileExit.Text = "關閉";
            // 
            // _menuItemPage
            // 
            this._menuItemPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemPageNew,
            this._menuItemPageFollowing,
            this._menuItemPageEnded,
            this._menuItemPageDispose});
            this._menuItemPage.Name = "_menuItemPage";
            this._menuItemPage.Size = new System.Drawing.Size(53, 24);
            this._menuItemPage.Text = "頁面";
            // 
            // _menuItemPageNew
            // 
            this._menuItemPageNew.Name = "_menuItemPageNew";
            this._menuItemPageNew.Size = new System.Drawing.Size(110, 24);
            this._menuItemPageNew.Text = "新番";
            // 
            // _menuItemPageFollowing
            // 
            this._menuItemPageFollowing.Name = "_menuItemPageFollowing";
            this._menuItemPageFollowing.Size = new System.Drawing.Size(110, 24);
            this._menuItemPageFollowing.Text = "追番";
            // 
            // _menuItemPageEnded
            // 
            this._menuItemPageEnded.Name = "_menuItemPageEnded";
            this._menuItemPageEnded.Size = new System.Drawing.Size(110, 24);
            this._menuItemPageEnded.Text = "完結";
            // 
            // _menuItemPageDispose
            // 
            this._menuItemPageDispose.Name = "_menuItemPageDispose";
            this._menuItemPageDispose.Size = new System.Drawing.Size(110, 24);
            this._menuItemPageDispose.Text = "棄番";
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._newPage);
            this._tabControl.Controls.Add(this._followingPage);
            this._tabControl.Controls.Add(this._endedPage);
            this._tabControl.Controls.Add(this._disposePage);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(0, 28);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(784, 533);
            this._tabControl.TabIndex = 2;
            // 
            // _newPage
            // 
            this._newPage.Controls.Add(this._animeListBox);
            this._newPage.Location = new System.Drawing.Point(4, 22);
            this._newPage.Name = "_newPage";
            this._newPage.Padding = new System.Windows.Forms.Padding(3);
            this._newPage.Size = new System.Drawing.Size(776, 507);
            this._newPage.TabIndex = 0;
            this._newPage.Text = "新番";
            this._newPage.UseVisualStyleBackColor = true;
            // 
            // _followingPage
            // 
            this._followingPage.Location = new System.Drawing.Point(4, 22);
            this._followingPage.Name = "_followingPage";
            this._followingPage.Padding = new System.Windows.Forms.Padding(3);
            this._followingPage.Size = new System.Drawing.Size(776, 507);
            this._followingPage.TabIndex = 1;
            this._followingPage.Text = "追番";
            this._followingPage.UseVisualStyleBackColor = true;
            // 
            // _endedPage
            // 
            this._endedPage.Location = new System.Drawing.Point(4, 22);
            this._endedPage.Name = "_endedPage";
            this._endedPage.Padding = new System.Windows.Forms.Padding(3);
            this._endedPage.Size = new System.Drawing.Size(776, 507);
            this._endedPage.TabIndex = 2;
            this._endedPage.Text = "完結";
            this._endedPage.UseVisualStyleBackColor = true;
            // 
            // _disposePage
            // 
            this._disposePage.Location = new System.Drawing.Point(4, 22);
            this._disposePage.Name = "_disposePage";
            this._disposePage.Padding = new System.Windows.Forms.Padding(3);
            this._disposePage.Size = new System.Drawing.Size(776, 507);
            this._disposePage.TabIndex = 3;
            this._disposePage.Text = "棄番";
            this._disposePage.UseVisualStyleBackColor = true;
            // 
            // _animeListBox
            // 
            this._animeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._animeListBox.FormattingEnabled = true;
            this._animeListBox.ItemHeight = 16;
            this._animeListBox.Items.AddRange(new object[] {
            "1111",
            "2222",
            "3333",
            "4444"});
            this._animeListBox.Location = new System.Drawing.Point(66, 50);
            this._animeListBox.Name = "_animeListBox";
            this._animeListBox.Size = new System.Drawing.Size(535, 340);
            this._animeListBox.TabIndex = 0;
            // 
            // AnimeManagementSystemForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.Name = "AnimeManagementSystemForm";
            this.Text = "新番管理系統";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._tabControl.ResumeLayout(false);
            this._newPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem _menuItemFileImport;
        private System.Windows.Forms.ToolStripMenuItem _menuItemFileExport;
        private System.Windows.Forms.ToolStripMenuItem _menuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem _menuItemPage;
        private System.Windows.Forms.ToolStripMenuItem _menuItemPageNew;
        private System.Windows.Forms.ToolStripMenuItem _menuItemPageFollowing;
        private System.Windows.Forms.ToolStripMenuItem _menuItemPageEnded;
        private System.Windows.Forms.ToolStripMenuItem _menuItemPageDispose;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _newPage;
        private System.Windows.Forms.TabPage _followingPage;
        private System.Windows.Forms.TabPage _endedPage;
        private System.Windows.Forms.TabPage _disposePage;
        private UserControls.AnimeListBox _animeListBox;

    }
}

