namespace DigitalProject.Forms
{
    partial class CategoryInformationForm
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
            this.categoryTitleLabel = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryTitleLabel
            // 
            this.categoryTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.categoryTitleLabel.Location = new System.Drawing.Point(12, 12);
            this.categoryTitleLabel.Name = "categoryTitleLabel";
            this.categoryTitleLabel.Size = new System.Drawing.Size(236, 36);
            this.categoryTitleLabel.TabIndex = 0;
            this.categoryTitleLabel.Text = "categoryTitleLabel";
            this.categoryTitleLabel.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 77);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(83, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Information";
            this.radLabel2.ThemeName = "MaterialTeal";
            // 
            // CategoryInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(615, 369);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.categoryTitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryInformationForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "CategoryInformationForm";
            this.ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)(this.categoryTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel categoryTitleLabel;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
    }
}
