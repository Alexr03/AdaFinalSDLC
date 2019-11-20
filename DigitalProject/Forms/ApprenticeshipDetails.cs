using System.Diagnostics;
using DigitalProject.Models;

namespace DigitalProject.Forms
{
    public partial class ApprenticeshipDetails : Telerik.WinControls.UI.RadForm
    {
        private Apprenticeship apprenticeship;

        public ApprenticeshipDetails(Apprenticeship apprenticeship)
        {
            this.apprenticeship = apprenticeship;
            InitializeComponent();
            this.AutoSize = true;
            this.Text = $"{apprenticeship.AppName} - {apprenticeship.Company}";
            titleLabel.Text = $"{apprenticeship.AppName} - {apprenticeship.Company}";
            companyLabel.Text = "Company: " + apprenticeship.Company;
            levelLabel.Text = "Level: " + apprenticeship.AppLevel;
            requirementsLabel.Text = "Requirements: " + apprenticeship.Requirements;
            qrCode.Value = apprenticeship.Link;
            successBarcode.Value = apprenticeship.Success ?? $"https://lmgtfy.com/?q={(apprenticeship.Company.Replace(" ", "+"))}+success+stories&iie=1";
        }

        private void VisitSiteButton_Click(object sender, System.EventArgs e)
        {
            Process.Start(apprenticeship.Link);
        }
    }
}
