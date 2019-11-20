using System;
using System.Windows.Forms;
using DigitalProject.Exceptions;
using DigitalProject.Models;

namespace DigitalProject.Forms
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RadButton1_Click(object sender, EventArgs e)
        {
            try
            {
                UserAccount userAccount = UserAccount.GetAccount(usernameBox.Text);
                if (userAccount.Password.Equals(Helpers.SecurityHelper.ConvertToMd5(passwordBox.Text)))
                {
                    this.Hide();
                    var homepageForm = new ApprenticeshipsForm(userAccount);
                    homepageForm.Closed += (o, args) => this.Close();
                    homepageForm.Show();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }
            }
            catch (UserNotFoundException)
            {
                MessageBox.Show("Username or password is incorrect.");
            }
        }
    }
}
