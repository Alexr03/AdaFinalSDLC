namespace DigitalProject.Forms
{
    partial class ApprenticeshipDetails
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
            Telerik.WinControls.UI.Barcode.Symbology.QRCode qrCode1 = new Telerik.WinControls.UI.Barcode.Symbology.QRCode();
            Telerik.WinControls.UI.Barcode.Symbology.QRCode qrCode2 = new Telerik.WinControls.UI.Barcode.Symbology.QRCode();
            this.titleLabel = new Telerik.WinControls.UI.RadLabel();
            this.levelLabel = new Telerik.WinControls.UI.RadLabel();
            this.visitSiteButton = new Telerik.WinControls.UI.RadButton();
            this.qrCode = new Telerik.WinControls.UI.RadBarcode();
            this.requirementsLabel = new Telerik.WinControls.UI.RadLabel();
            this.companyLabel = new Telerik.WinControls.UI.RadLabel();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.successBarcode = new Telerik.WinControls.UI.RadBarcode();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitSiteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.ThemeName = "Crystal";
            // 
            // levelLabel
            // 
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.levelLabel.Location = new System.Drawing.Point(12, 67);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(55, 25);
            this.levelLabel.TabIndex = 1;
            this.levelLabel.Text = "Level";
            this.levelLabel.ThemeName = "Crystal";
            // 
            // visitSiteButton
            // 
            this.visitSiteButton.Location = new System.Drawing.Point(12, 327);
            this.visitSiteButton.Name = "visitSiteButton";
            this.visitSiteButton.Size = new System.Drawing.Size(110, 24);
            this.visitSiteButton.TabIndex = 2;
            this.visitSiteButton.Text = "Visit Website";
            this.visitSiteButton.ThemeName = "Crystal";
            this.visitSiteButton.Click += new System.EventHandler(this.VisitSiteButton_Click);
            // 
            // qrCode
            // 
            this.qrCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.qrCode.Location = new System.Drawing.Point(321, 233);
            this.qrCode.Name = "qrCode";
            this.qrCode.Size = new System.Drawing.Size(125, 118);
            qrCode1.Version = 1;
            this.qrCode.Symbology = qrCode1;
            this.qrCode.TabIndex = 3;
            this.qrCode.Text = "radBarcode1";
            this.qrCode.ThemeName = "Crystal";
            this.qrCode.Value = "URL-HERE";
            // 
            // requirementsLabel
            // 
            this.requirementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.requirementsLabel.Location = new System.Drawing.Point(12, 129);
            this.requirementsLabel.Name = "requirementsLabel";
            this.requirementsLabel.Size = new System.Drawing.Size(129, 25);
            this.requirementsLabel.TabIndex = 2;
            this.requirementsLabel.Text = "Requirements";
            this.requirementsLabel.ThemeName = "Crystal";
            // 
            // companyLabel
            // 
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.companyLabel.Location = new System.Drawing.Point(12, 98);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(91, 25);
            this.companyLabel.TabIndex = 3;
            this.companyLabel.Text = "Company";
            this.companyLabel.ThemeName = "Crystal";
            // 
            // successBarcode
            // 
            this.successBarcode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.successBarcode.Location = new System.Drawing.Point(190, 233);
            this.successBarcode.Name = "successBarcode";
            this.successBarcode.Size = new System.Drawing.Size(125, 118);
            qrCode2.Version = 1;
            this.successBarcode.Symbology = qrCode2;
            this.successBarcode.TabIndex = 4;
            this.successBarcode.Text = "successBarcode";
            this.successBarcode.ThemeName = "Crystal";
            this.successBarcode.Value = "URL-HERE";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radLabel1.Location = new System.Drawing.Point(190, 209);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(105, 20);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Success Stories";
            this.radLabel1.ThemeName = "Crystal";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radLabel2.Location = new System.Drawing.Point(321, 209);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(56, 20);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Website";
            this.radLabel2.ThemeName = "Crystal";
            // 
            // ApprenticeshipDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 363);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.successBarcode);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.requirementsLabel);
            this.Controls.Add(this.qrCode);
            this.Controls.Add(this.visitSiteButton);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.titleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApprenticeshipDetails";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Apprenticeship Details";
            this.ThemeName = "Crystal";
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitSiteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel titleLabel;
        private Telerik.WinControls.UI.RadLabel levelLabel;
        private Telerik.WinControls.UI.RadButton visitSiteButton;
        private Telerik.WinControls.UI.RadBarcode qrCode;
        private Telerik.WinControls.UI.RadLabel companyLabel;
        private Telerik.WinControls.UI.RadLabel requirementsLabel;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadBarcode successBarcode;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
