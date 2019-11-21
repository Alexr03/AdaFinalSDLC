namespace DigitalProject.Forms
{
    partial class LoginForm
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
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.passwordBox = new Telerik.WinControls.UI.RadTextBox();
            this.usernameBox = new Telerik.WinControls.UI.RadTextBox();
            this.loginButton = new Telerik.WinControls.UI.RadButton();
            this.loginLabel = new Telerik.WinControls.UI.RadLabel();
            this.logoPanel = new Telerik.WinControls.UI.RadPanel();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(70, 200);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(200, 36);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.Text = "Password";
            this.passwordBox.ThemeName = "MaterialTeal";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(70, 160);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(200, 36);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.Text = "Username";
            this.usernameBox.ThemeName = "MaterialTeal";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(70, 250);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(194, 41);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.ThemeName = "MaterialTeal";
            this.loginButton.Click += new System.EventHandler(this.RadButton1_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(130, 109);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(80, 41);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login";
            this.loginLabel.ThemeName = "MaterialTeal";
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Transparent;
            this.logoPanel.BackgroundImage = global::DigitalProject.Properties.Resources.image3;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.ForeColor = System.Drawing.Color.Transparent;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(340, 100);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.ThemeName = "MaterialTeal";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 320);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.logoPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "";
            this.ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.UI.RadPanel logoPanel;
        private Telerik.WinControls.UI.RadTextBox passwordBox;
        private Telerik.WinControls.UI.RadTextBox usernameBox;
        private Telerik.WinControls.UI.RadButton loginButton;
        private Telerik.WinControls.UI.RadLabel loginLabel;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
    }
}
