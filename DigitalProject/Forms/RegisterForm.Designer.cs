namespace DigitalProject.Forms
{
    partial class RegisterForm
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
            this.loginLabel = new Telerik.WinControls.UI.RadLabel();
            this.logoPanel = new Telerik.WinControls.UI.RadPanel();
            this.usernameBox = new Telerik.WinControls.UI.RadTextBox();
            this.passwordBox = new Telerik.WinControls.UI.RadTextBox();
            this.firstNameBox = new Telerik.WinControls.UI.RadTextBox();
            this.lastNameBox = new Telerik.WinControls.UI.RadTextBox();
            this.registerButton = new Telerik.WinControls.UI.RadButton();
            this.birthdayBox = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.loginLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.loginLabel.Location = new System.Drawing.Point(110, 107);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(110, 41);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Register";
            this.loginLabel.ThemeName = "Crystal";
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Transparent;
            this.logoPanel.BackgroundImage = global::DigitalProject.Properties.Resources.image3;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Location = new System.Drawing.Point(-2, 2);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(337, 99);
            this.logoPanel.TabIndex = 5;
            this.logoPanel.ThemeName = "Crystal";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(59, 154);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(200, 28);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.Text = "Username";
            this.usernameBox.ThemeName = "Crystal";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(59, 184);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(200, 28);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.Text = "Password";
            this.passwordBox.ThemeName = "Crystal";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(59, 214);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(200, 28);
            this.firstNameBox.TabIndex = 3;
            this.firstNameBox.Text = "First Name";
            this.firstNameBox.ThemeName = "Crystal";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(59, 244);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(200, 28);
            this.lastNameBox.TabIndex = 4;
            this.lastNameBox.Text = "Last Name";
            this.lastNameBox.ThemeName = "Crystal";
            // 
            // registerButton
            // 
            this.registerButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.registerButton.Location = new System.Drawing.Point(59, 316);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(200, 53);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.ThemeName = "Crystal";
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // birthdayBox
            // 
            this.birthdayBox.CalendarSize = new System.Drawing.Size(290, 320);
            this.birthdayBox.Location = new System.Drawing.Point(59, 274);
            this.birthdayBox.Name = "birthdayBox";
            this.birthdayBox.Size = new System.Drawing.Size(200, 28);
            this.birthdayBox.TabIndex = 5;
            this.birthdayBox.TabStop = false;
            this.birthdayBox.Text = "01 January 2000";
            this.birthdayBox.ThemeName = "Crystal";
            this.birthdayBox.Value = new System.DateTime(2000, 1, 1, 19, 8, 0, 0);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 386);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.birthdayBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.logoPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "";
            this.ThemeName = "Crystal";
            ((System.ComponentModel.ISupportInitialize)(this.loginLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel loginLabel;
        private Telerik.WinControls.UI.RadPanel logoPanel;
        private Telerik.WinControls.UI.RadTextBox usernameBox;
        private Telerik.WinControls.UI.RadTextBox passwordBox;
        private Telerik.WinControls.UI.RadTextBox firstNameBox;
        private Telerik.WinControls.UI.RadTextBox lastNameBox;
        private Telerik.WinControls.UI.RadButton registerButton;
        private Telerik.WinControls.UI.RadDateTimePicker birthdayBox;
    }
}
