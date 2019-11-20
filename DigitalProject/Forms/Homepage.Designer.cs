namespace DigitalProject.Forms
{
    partial class Homepage
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
            this.accountDetailsPanel = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.accountDetailsLabel = new Telerik.WinControls.UI.RadLabel();
            this.accountInfoLabel = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apprenticeshipButton = new Telerik.WinControls.UI.RadButton();
            this.quizButton = new Telerik.WinControls.UI.RadButton();
            this.userProfileButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsPanel)).BeginInit();
            this.accountDetailsPanel.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticeshipButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDetailsPanel
            // 
            this.accountDetailsPanel.Location = new System.Drawing.Point(752, 12);
            this.accountDetailsPanel.Name = "accountDetailsPanel";
            // 
            // accountDetailsPanel.PanelContainer
            // 
            this.accountDetailsPanel.PanelContainer.Controls.Add(this.accountDetailsLabel);
            this.accountDetailsPanel.PanelContainer.Controls.Add(this.accountInfoLabel);
            this.accountDetailsPanel.PanelContainer.Size = new System.Drawing.Size(238, 80);
            this.accountDetailsPanel.Size = new System.Drawing.Size(240, 105);
            this.accountDetailsPanel.TabIndex = 1;
            this.accountDetailsPanel.ThemeName = "Crystal";
            // 
            // accountDetailsLabel
            // 
            this.accountDetailsLabel.Location = new System.Drawing.Point(12, 29);
            this.accountDetailsLabel.Name = "accountDetailsLabel";
            this.accountDetailsLabel.Size = new System.Drawing.Size(172, 20);
            this.accountDetailsLabel.TabIndex = 1;
            this.accountDetailsLabel.Text = "AccountDetailsPlaceholder";
            this.accountDetailsLabel.ThemeName = "Crystal";
            // 
            // accountInfoLabel
            // 
            this.accountInfoLabel.Location = new System.Drawing.Point(52, 3);
            this.accountInfoLabel.Name = "accountInfoLabel";
            this.accountInfoLabel.Size = new System.Drawing.Size(132, 20);
            this.accountInfoLabel.TabIndex = 0;
            this.accountInfoLabel.Text = "Account Information";
            this.accountInfoLabel.ThemeName = "Crystal";
            // 
            // radPanel1
            // 
            this.radPanel1.AutoSize = true;
            this.radPanel1.Location = new System.Drawing.Point(40, 91);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(2, 2);
            this.radPanel1.TabIndex = 2;
            this.radPanel1.ThemeName = "Crystal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apprenticeship";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(456, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quiz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "User profile";
            // 
            // apprenticeshipButton
            // 
            this.apprenticeshipButton.BackColor = System.Drawing.Color.Transparent;
            this.apprenticeshipButton.BackgroundImage = global::DigitalProject.Properties.Resources.image3;
            this.apprenticeshipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apprenticeshipButton.Location = new System.Drawing.Point(152, 168);
            this.apprenticeshipButton.Name = "apprenticeshipButton";
            this.apprenticeshipButton.Size = new System.Drawing.Size(130, 130);
            this.apprenticeshipButton.TabIndex = 9;
            this.apprenticeshipButton.ThemeName = "Crystal";
            this.apprenticeshipButton.Click += new System.EventHandler(this.ApprenticeshipButton_Click);
            // 
            // quizButton
            // 
            this.quizButton.BackColor = System.Drawing.Color.Transparent;
            this.quizButton.BackgroundImage = global::DigitalProject.Properties.Resources.image3;
            this.quizButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quizButton.Location = new System.Drawing.Point(415, 168);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(130, 130);
            this.quizButton.TabIndex = 10;
            this.quizButton.ThemeName = "Crystal";
            this.quizButton.Click += new System.EventHandler(this.QuizButton_Click);
            // 
            // userProfileButton
            // 
            this.userProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.userProfileButton.BackgroundImage = global::DigitalProject.Properties.Resources.image3;
            this.userProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userProfileButton.Location = new System.Drawing.Point(681, 168);
            this.userProfileButton.Name = "userProfileButton";
            this.userProfileButton.Size = new System.Drawing.Size(130, 130);
            this.userProfileButton.TabIndex = 10;
            this.userProfileButton.ThemeName = "Crystal";
            this.userProfileButton.Click += new System.EventHandler(this.UserProfileButton_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 486);
            this.Controls.Add(this.userProfileButton);
            this.Controls.Add(this.quizButton);
            this.Controls.Add(this.apprenticeshipButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.accountDetailsPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homepage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Homepage";
            this.ThemeName = "Crystal";
            this.accountDetailsPanel.PanelContainer.ResumeLayout(false);
            this.accountDetailsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDetailsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticeshipButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCollapsiblePanel accountDetailsPanel;
        private Telerik.WinControls.UI.RadLabel accountDetailsLabel;
        private Telerik.WinControls.UI.RadLabel accountInfoLabel;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton apprenticeshipButton;
        private Telerik.WinControls.UI.RadButton quizButton;
        private Telerik.WinControls.UI.RadButton userProfileButton;
    }
}
