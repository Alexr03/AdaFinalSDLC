using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DigitalProject.Models;
using Telerik.WinControls;

namespace DigitalProject.Forms
{
    public partial class WelcomeForm : Telerik.WinControls.UI.RadForm
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Closed += (o, args) => this.Close();
            loginForm.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new RegisterForm();
            loginForm.Closed += (o, args) => this.Close();
            loginForm.Show();
        }
    }
}
