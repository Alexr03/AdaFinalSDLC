using System;
using DigitalProject.Models;
using Telerik.WinControls.UI;

namespace DigitalProject.Forms
{
    public partial class RegisterForm : Telerik.WinControls.UI.RadForm
    {
        public RegisterForm()
        {
            InitializeComponent();

            passwordBox.GotFocus += RemovePlaceholder;
            usernameBox.GotFocus += RemovePlaceholder;
            firstNameBox.GotFocus += RemovePlaceholder;
            lastNameBox.GotFocus += RemovePlaceholder;
            birthdayBox.Text = "Birthday";
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            RadTextBox textBox = (RadTextBox) sender;
            textBox.Text = "";
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var hashedPassword = Helpers.SecurityHelper.ConvertToMd5(passwordBox.Text);
            UserAccount userAccount = new UserAccount
            {
                DateOfBirth = birthdayBox.Value,
                FirstName = firstNameBox.Text,
                LastName = lastNameBox.Text,
                Password = hashedPassword,
                Username = usernameBox.Text
            };

            UserAccount.CreateUserAccount(userAccount);

            this.Hide();
            var apprenticeshipForm = new ApprenticeshipsForm(userAccount);
            apprenticeshipForm.Closed += (o, args) => this.Close();
            apprenticeshipForm.Show();
        }
    }
}
