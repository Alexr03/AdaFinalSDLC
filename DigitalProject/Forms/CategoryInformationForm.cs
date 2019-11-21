using DigitalProject.Models;

namespace DigitalProject.Forms
{
    public partial class CategoryInformationForm : Telerik.WinControls.UI.RadForm
    {
        public CategoryInformationForm(CategoryInformation categoryInfo, string title)
        {
            InitializeComponent();
            this.Text = $"Information - {title}";
            this.categoryTitleLabel.Text = title;
            this.radLabel2.Text = categoryInfo.Information;
        }
    }
}
