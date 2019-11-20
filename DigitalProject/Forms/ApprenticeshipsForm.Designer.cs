namespace DigitalProject.Forms
{
    partial class ApprenticeshipsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn10 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "ID");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn11 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Company");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn12 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Name");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn13 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Level");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn14 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 6", "Location");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn15 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Requirements");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn16 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Required Points");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Placement");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Name");
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.tabViews = new Telerik.WinControls.UI.RadPageView();
            this.apprenticeshipsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.apprenticeshipList = new Telerik.WinControls.UI.RadListView();
            this.leaderboardPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.leaderboardList = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this.tabViews)).BeginInit();
            this.tabViews.SuspendLayout();
            this.apprenticeshipsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticeshipList)).BeginInit();
            this.leaderboardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tabViews
            // 
            this.tabViews.Controls.Add(this.apprenticeshipsPage);
            this.tabViews.Controls.Add(this.leaderboardPage);
            this.tabViews.DefaultPage = this.apprenticeshipsPage;
            this.tabViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabViews.Location = new System.Drawing.Point(0, 0);
            this.tabViews.Name = "tabViews";
            this.tabViews.SelectedPage = this.leaderboardPage;
            this.tabViews.Size = new System.Drawing.Size(1126, 469);
            this.tabViews.TabIndex = 5;
            this.tabViews.ThemeName = "Crystal";
            this.tabViews.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.tabViews.GetChildAt(0))).ExpandedPaneWidth = 150;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.tabViews.GetChildAt(0))).CollapsedPaneWidth = 40;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.tabViews.GetChildAt(0))).ExpandedModeThresholdWidth = 800;
            // 
            // apprenticeshipsPage
            // 
            this.apprenticeshipsPage.Controls.Add(this.apprenticeshipList);
            this.apprenticeshipsPage.ItemSize = new System.Drawing.SizeF(122F, 36F);
            this.apprenticeshipsPage.Location = new System.Drawing.Point(123, 31);
            this.apprenticeshipsPage.Name = "apprenticeshipsPage";
            this.apprenticeshipsPage.Size = new System.Drawing.Size(1002, 437);
            this.apprenticeshipsPage.Text = "Apprenticeships";
            // 
            // apprenticeshipList
            // 
            this.apprenticeshipList.AllowEdit = false;
            this.apprenticeshipList.AllowRemove = false;
            listViewDetailColumn10.HeaderText = "ID";
            listViewDetailColumn10.Width = 30F;
            listViewDetailColumn11.HeaderText = "Company";
            listViewDetailColumn11.Width = 150F;
            listViewDetailColumn12.HeaderText = "Name";
            listViewDetailColumn12.Width = 150F;
            listViewDetailColumn13.HeaderText = "Level";
            listViewDetailColumn13.Width = 60F;
            listViewDetailColumn14.HeaderText = "Location";
            listViewDetailColumn15.HeaderText = "Requirements";
            listViewDetailColumn15.Width = 250F;
            listViewDetailColumn16.HeaderText = "Required Points";
            listViewDetailColumn16.Width = 150F;
            this.apprenticeshipList.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn10,
            listViewDetailColumn11,
            listViewDetailColumn12,
            listViewDetailColumn13,
            listViewDetailColumn14,
            listViewDetailColumn15,
            listViewDetailColumn16});
            this.apprenticeshipList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apprenticeshipList.EnableColumnSort = true;
            this.apprenticeshipList.EnableFiltering = true;
            this.apprenticeshipList.EnableSorting = true;
            this.apprenticeshipList.GroupItemSize = new System.Drawing.Size(200, 28);
            this.apprenticeshipList.ItemSize = new System.Drawing.Size(200, 28);
            this.apprenticeshipList.ItemSpacing = -1;
            this.apprenticeshipList.KeyboardSearchEnabled = true;
            this.apprenticeshipList.Location = new System.Drawing.Point(0, 0);
            this.apprenticeshipList.Name = "apprenticeshipList";
            this.apprenticeshipList.ShowGridLines = true;
            this.apprenticeshipList.Size = new System.Drawing.Size(1002, 437);
            this.apprenticeshipList.TabIndex = 2;
            this.apprenticeshipList.ThemeName = "Crystal";
            this.apprenticeshipList.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // leaderboardPage
            // 
            this.leaderboardPage.Controls.Add(this.leaderboardList);
            this.leaderboardPage.ItemSize = new System.Drawing.SizeF(122F, 36F);
            this.leaderboardPage.Location = new System.Drawing.Point(123, 31);
            this.leaderboardPage.Name = "leaderboardPage";
            this.leaderboardPage.Size = new System.Drawing.Size(1002, 437);
            this.leaderboardPage.Text = "Leaderboard";
            // 
            // leaderboardList
            // 
            listViewDetailColumn1.HeaderText = "Placement";
            listViewDetailColumn1.Width = 150F;
            listViewDetailColumn2.HeaderText = "Name";
            listViewDetailColumn2.Width = 600F;
            this.leaderboardList.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2});
            this.leaderboardList.GroupItemSize = new System.Drawing.Size(200, 28);
            this.leaderboardList.ItemSize = new System.Drawing.Size(200, 28);
            this.leaderboardList.ItemSpacing = -1;
            this.leaderboardList.Location = new System.Drawing.Point(3, 3);
            this.leaderboardList.Name = "leaderboardList";
            this.leaderboardList.Size = new System.Drawing.Size(988, 423);
            this.leaderboardList.TabIndex = 0;
            this.leaderboardList.ThemeName = "Crystal";
            this.leaderboardList.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // ApprenticeshipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1126, 469);
            this.Controls.Add(this.tabViews);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApprenticeshipsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "";
            this.ThemeName = "Crystal";
            ((System.ComponentModel.ISupportInitialize)(this.tabViews)).EndInit();
            this.tabViews.ResumeLayout(false);
            this.apprenticeshipsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apprenticeshipList)).EndInit();
            this.leaderboardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadPageView tabViews;
        private Telerik.WinControls.UI.RadPageViewPage apprenticeshipsPage;
        private Telerik.WinControls.UI.RadListView apprenticeshipList;
        private Telerik.WinControls.UI.RadPageViewPage leaderboardPage;
        private Telerik.WinControls.UI.RadListView leaderboardList;
    }
}
