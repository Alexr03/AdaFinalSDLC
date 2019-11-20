using DigitalProject.Models;

namespace DigitalProject.Forms
{
    public partial class CategoryInformationForm : Telerik.WinControls.UI.RadForm
    {
        public CategoryInformationForm(CategoryInformation categoryInfo, string title)
        {
            InitializeComponent();
            this.categoryTitleLabel.Text = title;
            this.radLabel2.Text = categoryInfo.Information;
        }
    }
}
