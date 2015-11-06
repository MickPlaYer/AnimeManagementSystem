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
            this._menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemEditNew = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemEditModify = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPage = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPageNew = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPageFollowing = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPageEnded = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPageDispose = new System.Windows.Forms.ToolStripMenuItem();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._newPage = new System.Windows.Forms.TabPage();
            this._newPageContentsBox = new System.Windows.Forms.GroupBox();
            this._newPageTitleContent = new System.Windows.Forms.Label();
            this._newPageDescriptionLabel = new System.Windows.Forms.Label();
            this._newPageDescriptionContent = new System.Windows.Forms.Label();
            this._newPageTitleLabel = new System.Windows.Forms.Label();
            this._newPageBanner = new System.Windows.Forms.PictureBox();
            this._showContactedCheck = new System.Windows.Forms.CheckBox();
            this._disposeNewButton = new System.Windows.Forms.Button();
            this._followNewButton = new System.Windows.Forms.Button();
            this._newPageQuarterSelecter = new System.Windows.Forms.ComboBox();
            this._followingPage = new System.Windows.Forms.TabPage();
            this._endedPage = new System.Windows.Forms.TabPage();
            this._disposePage = new System.Windows.Forms.TabPage();
            this._newPageAnimeListBox = new AnimeManagementSystem.View.UserControls.AnimeListBox();
            this._menuStrip.SuspendLayout();
            this._tabControl.SuspendLayout();
            this._newPage.SuspendLayout();
            this._newPageContentsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._newPageBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemFile,
            this._menuItemEdit,
            this._menuItemPage});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(967, 24);
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
            this._menuItemFile.Size = new System.Drawing.Size(41, 20);
            this._menuItemFile.Text = "檔案";
            // 
            // _menuItemFileImport
            // 
            this._menuItemFileImport.Name = "_menuItemFileImport";
            this._menuItemFileImport.Size = new System.Drawing.Size(94, 22);
            this._menuItemFileImport.Text = "匯入";
            // 
            // _menuItemFileExport
            // 
            this._menuItemFileExport.Name = "_menuItemFileExport";
            this._menuItemFileExport.Size = new System.Drawing.Size(94, 22);
            this._menuItemFileExport.Text = "匯出";
            // 
            // _menuItemFileExit
            // 
            this._menuItemFileExit.Name = "_menuItemFileExit";
            this._menuItemFileExit.Size = new System.Drawing.Size(94, 22);
            this._menuItemFileExit.Text = "關閉";
            // 
            // _menuItemEdit
            // 
            this._menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemEditNew,
            this._menuItemEditModify,
            this._menuItemEditDelete});
            this._menuItemEdit.Name = "_menuItemEdit";
            this._menuItemEdit.Size = new System.Drawing.Size(41, 20);
            this._menuItemEdit.Text = "編輯";
            // 
            // _menuItemEditNew
            // 
            this._menuItemEditNew.Name = "_menuItemEditNew";
            this._menuItemEditNew.Size = new System.Drawing.Size(94, 22);
            this._menuItemEditNew.Text = "新增";
            this._menuItemEditNew.Click += new System.EventHandler(this.OnAddAnime);
            // 
            // _menuItemEditModify
            // 
            this._menuItemEditModify.Name = "_menuItemEditModify";
            this._menuItemEditModify.Size = new System.Drawing.Size(94, 22);
            this._menuItemEditModify.Text = "修改";
            // 
            // _menuItemEditDelete
            // 
            this._menuItemEditDelete.Name = "_menuItemEditDelete";
            this._menuItemEditDelete.Size = new System.Drawing.Size(94, 22);
            this._menuItemEditDelete.Text = "刪除";
            // 
            // _menuItemPage
            // 
            this._menuItemPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemPageNew,
            this._menuItemPageFollowing,
            this._menuItemPageEnded,
            this._menuItemPageDispose});
            this._menuItemPage.Name = "_menuItemPage";
            this._menuItemPage.Size = new System.Drawing.Size(41, 20);
            this._menuItemPage.Text = "頁面";
            // 
            // _menuItemPageNew
            // 
            this._menuItemPageNew.Checked = true;
            this._menuItemPageNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this._menuItemPageNew.Name = "_menuItemPageNew";
            this._menuItemPageNew.Size = new System.Drawing.Size(94, 22);
            this._menuItemPageNew.Tag = "New";
            this._menuItemPageNew.Text = "新番";
            this._menuItemPageNew.Click += new System.EventHandler(this.OnClickItemPageNew);
            // 
            // _menuItemPageFollowing
            // 
            this._menuItemPageFollowing.Checked = true;
            this._menuItemPageFollowing.CheckState = System.Windows.Forms.CheckState.Checked;
            this._menuItemPageFollowing.Name = "_menuItemPageFollowing";
            this._menuItemPageFollowing.Size = new System.Drawing.Size(94, 22);
            this._menuItemPageFollowing.Tag = "Following";
            this._menuItemPageFollowing.Text = "追番";
            this._menuItemPageFollowing.Click += new System.EventHandler(this.OnClickItemPageNew);
            // 
            // _menuItemPageEnded
            // 
            this._menuItemPageEnded.Checked = true;
            this._menuItemPageEnded.CheckState = System.Windows.Forms.CheckState.Checked;
            this._menuItemPageEnded.Name = "_menuItemPageEnded";
            this._menuItemPageEnded.Size = new System.Drawing.Size(94, 22);
            this._menuItemPageEnded.Tag = "Ended";
            this._menuItemPageEnded.Text = "完結";
            this._menuItemPageEnded.Click += new System.EventHandler(this.OnClickItemPageNew);
            // 
            // _menuItemPageDispose
            // 
            this._menuItemPageDispose.Checked = true;
            this._menuItemPageDispose.CheckState = System.Windows.Forms.CheckState.Checked;
            this._menuItemPageDispose.Name = "_menuItemPageDispose";
            this._menuItemPageDispose.Size = new System.Drawing.Size(94, 22);
            this._menuItemPageDispose.Tag = "Dispose";
            this._menuItemPageDispose.Text = "棄番";
            this._menuItemPageDispose.Click += new System.EventHandler(this.OnClickItemPageNew);
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._newPage);
            this._tabControl.Controls.Add(this._followingPage);
            this._tabControl.Controls.Add(this._endedPage);
            this._tabControl.Controls.Add(this._disposePage);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._tabControl.Location = new System.Drawing.Point(0, 24);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(967, 742);
            this._tabControl.TabIndex = 2;
            this._tabControl.SelectedIndexChanged += new System.EventHandler(this.OnPageChanged);
            // 
            // _newPage
            // 
            this._newPage.Controls.Add(this._newPageContentsBox);
            this._newPage.Controls.Add(this._showContactedCheck);
            this._newPage.Controls.Add(this._disposeNewButton);
            this._newPage.Controls.Add(this._followNewButton);
            this._newPage.Controls.Add(this._newPageQuarterSelecter);
            this._newPage.Controls.Add(this._newPageAnimeListBox);
            this._newPage.Location = new System.Drawing.Point(4, 29);
            this._newPage.Name = "_newPage";
            this._newPage.Padding = new System.Windows.Forms.Padding(3);
            this._newPage.Size = new System.Drawing.Size(959, 709);
            this._newPage.TabIndex = 0;
            this._newPage.Tag = "New";
            this._newPage.Text = "新番";
            this._newPage.UseVisualStyleBackColor = true;
            // 
            // _newPageContentsBox
            // 
            this._newPageContentsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._newPageContentsBox.Controls.Add(this._newPageTitleContent);
            this._newPageContentsBox.Controls.Add(this._newPageDescriptionLabel);
            this._newPageContentsBox.Controls.Add(this._newPageDescriptionContent);
            this._newPageContentsBox.Controls.Add(this._newPageTitleLabel);
            this._newPageContentsBox.Controls.Add(this._newPageBanner);
            this._newPageContentsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._newPageContentsBox.Location = new System.Drawing.Point(339, 6);
            this._newPageContentsBox.Name = "_newPageContentsBox";
            this._newPageContentsBox.Size = new System.Drawing.Size(617, 661);
            this._newPageContentsBox.TabIndex = 3;
            this._newPageContentsBox.TabStop = false;
            this._newPageContentsBox.Tag = "New";
            this._newPageContentsBox.Text = "詳細";
            // 
            // _newPageTitleContent
            // 
            this._newPageTitleContent.AutoSize = true;
            this._newPageTitleContent.Location = new System.Drawing.Point(69, 231);
            this._newPageTitleContent.Name = "_newPageTitleContent";
            this._newPageTitleContent.Size = new System.Drawing.Size(34, 20);
            this._newPageTitleContent.TabIndex = 8;
            this._newPageTitleContent.Tag = "Title";
            this._newPageTitleContent.Text = "-----";
            // 
            // _newPageDescriptionLabel
            // 
            this._newPageDescriptionLabel.AutoSize = true;
            this._newPageDescriptionLabel.Location = new System.Drawing.Point(6, 251);
            this._newPageDescriptionLabel.Name = "_newPageDescriptionLabel";
            this._newPageDescriptionLabel.Size = new System.Drawing.Size(57, 20);
            this._newPageDescriptionLabel.TabIndex = 7;
            this._newPageDescriptionLabel.Text = "介紹：";
            // 
            // _newPageDescriptionContent
            // 
            this._newPageDescriptionContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._newPageDescriptionContent.BackColor = System.Drawing.Color.Transparent;
            this._newPageDescriptionContent.Location = new System.Drawing.Point(6, 271);
            this._newPageDescriptionContent.Name = "_newPageDescriptionContent";
            this._newPageDescriptionContent.Size = new System.Drawing.Size(600, 387);
            this._newPageDescriptionContent.TabIndex = 4;
            this._newPageDescriptionContent.Tag = "Description";
            this._newPageDescriptionContent.Text = "\n";
            // 
            // _newPageTitleLabel
            // 
            this._newPageTitleLabel.AutoSize = true;
            this._newPageTitleLabel.Location = new System.Drawing.Point(6, 231);
            this._newPageTitleLabel.Name = "_newPageTitleLabel";
            this._newPageTitleLabel.Size = new System.Drawing.Size(57, 20);
            this._newPageTitleLabel.TabIndex = 3;
            this._newPageTitleLabel.Text = "標題：";
            // 
            // _newPageBanner
            // 
            this._newPageBanner.Location = new System.Drawing.Point(6, 28);
            this._newPageBanner.Name = "_newPageBanner";
            this._newPageBanner.Size = new System.Drawing.Size(600, 200);
            this._newPageBanner.TabIndex = 2;
            this._newPageBanner.TabStop = false;
            this._newPageBanner.Tag = "Banner";
            // 
            // _showContactedCheck
            // 
            this._showContactedCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._showContactedCheck.AutoSize = true;
            this._showContactedCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._showContactedCheck.Location = new System.Drawing.Point(193, 679);
            this._showContactedCheck.Name = "_showContactedCheck";
            this._showContactedCheck.Size = new System.Drawing.Size(140, 24);
            this._showContactedCheck.TabIndex = 2;
            this._showContactedCheck.Text = "顯示已追或已棄";
            this._showContactedCheck.UseVisualStyleBackColor = true;
            // 
            // _disposeNewButton
            // 
            this._disposeNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._disposeNewButton.Enabled = false;
            this._disposeNewButton.Location = new System.Drawing.Point(747, 673);
            this._disposeNewButton.Name = "_disposeNewButton";
            this._disposeNewButton.Size = new System.Drawing.Size(100, 30);
            this._disposeNewButton.TabIndex = 5;
            this._disposeNewButton.Text = "棄番";
            this._disposeNewButton.UseVisualStyleBackColor = true;
            // 
            // _followNewButton
            // 
            this._followNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._followNewButton.Enabled = false;
            this._followNewButton.Location = new System.Drawing.Point(853, 673);
            this._followNewButton.Name = "_followNewButton";
            this._followNewButton.Size = new System.Drawing.Size(100, 30);
            this._followNewButton.TabIndex = 6;
            this._followNewButton.Text = "追番";
            this._followNewButton.UseVisualStyleBackColor = true;
            // 
            // _newPageQuarterSelecter
            // 
            this._newPageQuarterSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newPageQuarterSelecter.Items.AddRange(new object[] {
            "1",
            "2",
            "333"});
            this._newPageQuarterSelecter.Location = new System.Drawing.Point(6, 6);
            this._newPageQuarterSelecter.Name = "_newPageQuarterSelecter";
            this._newPageQuarterSelecter.Size = new System.Drawing.Size(327, 28);
            this._newPageQuarterSelecter.TabIndex = 1;
            // 
            // _followingPage
            // 
            this._followingPage.Location = new System.Drawing.Point(4, 29);
            this._followingPage.Name = "_followingPage";
            this._followingPage.Padding = new System.Windows.Forms.Padding(3);
            this._followingPage.Size = new System.Drawing.Size(959, 709);
            this._followingPage.TabIndex = 1;
            this._followingPage.Tag = "Following";
            this._followingPage.Text = "追番";
            this._followingPage.UseVisualStyleBackColor = true;
            // 
            // _endedPage
            // 
            this._endedPage.Location = new System.Drawing.Point(4, 29);
            this._endedPage.Name = "_endedPage";
            this._endedPage.Padding = new System.Windows.Forms.Padding(3);
            this._endedPage.Size = new System.Drawing.Size(959, 709);
            this._endedPage.TabIndex = 2;
            this._endedPage.Tag = "Ended";
            this._endedPage.Text = "完結";
            this._endedPage.UseVisualStyleBackColor = true;
            // 
            // _disposePage
            // 
            this._disposePage.Location = new System.Drawing.Point(4, 29);
            this._disposePage.Name = "_disposePage";
            this._disposePage.Padding = new System.Windows.Forms.Padding(3);
            this._disposePage.Size = new System.Drawing.Size(959, 709);
            this._disposePage.TabIndex = 3;
            this._disposePage.Tag = "Dispose";
            this._disposePage.Text = "棄番";
            this._disposePage.UseVisualStyleBackColor = true;
            // 
            // _newPageAnimeListBox
            // 
            this._newPageAnimeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this._newPageAnimeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._newPageAnimeListBox.FormattingEnabled = true;
            this._newPageAnimeListBox.ItemHeight = 106;
            this._newPageAnimeListBox.Location = new System.Drawing.Point(6, 40);
            this._newPageAnimeListBox.Name = "_newPageAnimeListBox";
            this._newPageAnimeListBox.ScrollAlwaysVisible = true;
            this._newPageAnimeListBox.Size = new System.Drawing.Size(327, 635);
            this._newPageAnimeListBox.TabIndex = 0;
            this._newPageAnimeListBox.Tag = "New";
            this._newPageAnimeListBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedItemChanged);
            this._newPageAnimeListBox.SelectedValueChanged += new System.EventHandler(this.OnSelectedItemChanged);
            // 
            // AnimeManagementSystemForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(967, 766);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.MinimumSize = new System.Drawing.Size(975, 800);
            this.Name = "AnimeManagementSystemForm";
            this.Text = "新番管理系統";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._tabControl.ResumeLayout(false);
            this._newPage.ResumeLayout(false);
            this._newPage.PerformLayout();
            this._newPageContentsBox.ResumeLayout(false);
            this._newPageContentsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._newPageBanner)).EndInit();
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
        private UserControls.AnimeListBox _newPageAnimeListBox;
        private System.Windows.Forms.ComboBox _newPageQuarterSelecter;
        private System.Windows.Forms.CheckBox _showContactedCheck;
        private System.Windows.Forms.GroupBox _newPageContentsBox;
        private System.Windows.Forms.PictureBox _newPageBanner;
        private System.Windows.Forms.Label _newPageTitleLabel;
        private System.Windows.Forms.Label _newPageDescriptionContent;
        private System.Windows.Forms.Button _followNewButton;
        private System.Windows.Forms.Button _disposeNewButton;
        private System.Windows.Forms.ToolStripMenuItem _menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem _menuItemEditNew;
        private System.Windows.Forms.ToolStripMenuItem _menuItemEditModify;
        private System.Windows.Forms.ToolStripMenuItem _menuItemEditDelete;
        private System.Windows.Forms.Label _newPageTitleContent;
        private System.Windows.Forms.Label _newPageDescriptionLabel;

    }
}

