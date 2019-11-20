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
    public partial class Homepage : Telerik.WinControls.UI.RadForm
    {
        private UserAccount userAccount;

        public Homepage(UserAccount userAccount)
        {
            InitializeComponent();
            this.userAccount = userAccount;
            SetAccountDetailsLabel();
        }

        private void SetAccountDetailsLabel()
        {
            string details = $"Name: {userAccount.FirstName} {userAccount.LastName}\n" +
                             $"Date of birth: {userAccount.DateOfBirth.ToLongDateString()}\n" + 
                             $"Points: {userAccount.Points}\n";

            accountDetailsLabel.Text = details;
        }

        private void ApprenticeshipButton_Click(object sender, EventArgs e)
        {
            var apprenticeshipsForm = new ApprenticeshipsForm(userAccount);
            apprenticeshipsForm.Show();
        }

        private void QuizButton_Click(object sender, EventArgs e)
        {
            //Todo Quiz Form
        }

        private void UserProfileButton_Click(object sender, EventArgs e)
        {
            //Todo User Profile Form
        }
    }
}
