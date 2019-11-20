using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DigitalProject.Models;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace DigitalProject.Forms
{
    public partial class ApprenticeshipsForm : Telerik.WinControls.UI.RadForm
    {
        private UserAccount _userAccount;

        public ApprenticeshipsForm(UserAccount account)
        {
            InitializeComponent();
            this._userAccount = account;
            AddCategories();

            AddApprenticeshipsToList();
            ProcessLeaderboard();

            apprenticeshipList.ItemMouseDoubleClick += ApprenticeshipListOnItemMouseDoubleClick;
        }

        private void ApprenticeshipListOnItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
        {
            var registerForm = new ApprenticeshipDetails(Apprenticeship.GetApprenticeship(Convert.ToInt32(e.Item.SubItems[0].ToString())));
            registerForm.Show();
        }

        private void AddApprenticeshipsToList()
        {
            apprenticeshipList.Items.Clear();
            var apprenticeships = Apprenticeship.GetApprenticeships();
            foreach (Apprenticeship apprenticeship in apprenticeships)
            {
                ListViewDataItem dataItem = new ListViewDataItem
                {
                    [0] = apprenticeship.ApprenticeshipId,
                    [1] = apprenticeship.Company,
                    [2] = apprenticeship.AppName,
                    [3] = apprenticeship.AppLevel,
                    [4] = apprenticeship.Location,
                    [5] = apprenticeship.Requirements,
                    [6] = apprenticeship.Points,
                };

                if (!IsUnlocked(apprenticeship))
                {
                    for (int i = 0; i < dataItem.SubItems.Count - 1; i++)
                    {
                        dataItem.SubItems[i] = "**Locked**";
                    }

                    dataItem.Enabled = false;
                    dataItem.BackColor = Color.LightGray;
                }

                apprenticeshipList.Items.Add(dataItem);
            }
        }

        private void AddCategories()
        {
            var categories = Category.GetCategories();
            foreach (var category in categories)
            {
                var questions = Question.GetQuestions(category.CategoryId);

                RadPageViewPage newPage = new RadPageViewPage
                {
                    Name = category.CategoryName + "_cat",
                    Text = category.CategoryName,
                    Title = category.CategoryName
                };

                RadWizard radWizard = new RadWizard
                {
                    Name = $"wizard_{category.CategoryName}",
                    Text = category.CategoryName,
                    ThemeName = "Crystal",
                    Dock = DockStyle.Fill,
                    CancelButton = { Visibility = ElementVisibility.Hidden },
                    FinishButton = { Visibility = ElementVisibility.Visible },
                    BackButton = { Visibility = ElementVisibility.Hidden },
                    HelpButton = { Visibility = ElementVisibility.Hidden},
                };

                radWizard.Finish += RadWizardOnFinish;
                radWizard.Next += RadWizardOnNext;

                foreach (var question in questions)
                {
                    var answers = Answer.GetAnswers(question.QuestionId);

                    WizardPage wizardPage = new WizardPage
                    {
                        Tag = question,
                        Text = category.CategoryName,
                        Title = category.CategoryName,
                        AutoSize = true,
                    };

                    RadGroupBox radGroupBox = new RadGroupBox()
                    {
                        HeaderText = "Answers",
                        Name = $"answers_{category.CategoryId}",
                        Location = new Point(25, 80),
                        Size = new Size(600, 250),
                        ThemeName = "Crystal",
                    };

                    RadLabel questionLabel = new RadLabel
                    {
                        ThemeName = "Crystal",
                        Name = $"q_{question.QuestionId}Label",
                        Text = $"{question.question}",
                        AutoSize = true,
                        Location = new Point(25, 25),
                        Font = new Font(FontFamily.GenericSerif, 15)
                    };

                    int i = 1;
                    foreach(Answer answer in answers)
                    {
                        radGroupBox.Controls.Add(new RadRadioButton()
                        {
                            Name = "answer_" + answer.AnswerId,
                            Text = answer.answer,
                            Tag = answer,
                            Location = new Point(30, 85 + (20 * i)),
                            ThemeName = "Crystal"
                        });
                        i++;
                    }

                    wizardPage.ContentArea = new Panel();
                    radWizard.Pages.Add(wizardPage);

                    RadButton detailsButton = new RadButton {
                        Text = "Details",
                        Location = new Point(450, 250),
                        ThemeName = "Crystal"
                    };
                    detailsButton.Click += delegate(object sender, EventArgs args)
                    {
                        var catInfo = CategoryInfo.GetCategoryInfo(category.CategoryId);
                        var detailsForm = new CategoryInformationForm(catInfo, category.CategoryName);
                        detailsForm.Show();
                    };

                    wizardPage.ContentArea.Controls.Add(detailsButton);
                    wizardPage.ContentArea.Controls.Add(questionLabel);
                    wizardPage.ContentArea.Controls.Add(radGroupBox);
                }

                //radWizard.Pages.Add(radWizard.CompletionPage);

                newPage.Controls.Add(radWizard);
                tabViews.Pages.Add(newPage);
            }
        }

        private void RadWizardOnNext(object sender, WizardCancelEventArgs e)
        {
            RadWizard wizard = (RadWizard)sender;
            var page = wizard.SelectedPage;

            var groupBox = page.ContentArea.Controls.OfType<RadGroupBox>().FirstOrDefault();

            var button = groupBox.Controls.OfType<RadRadioButton>().FirstOrDefault(x => x.IsChecked);

            if (button == null)
            {
                e.Cancel = true;
            }
        }

        private void RadWizardOnFinish(object sender, EventArgs e)
        {
            RadWizard wizard = (RadWizard) sender;
            int score = 0;
            bool valid = true;

            foreach (var page in wizard.Pages)
            {
                Question question = (Question)page.Tag;

                var groupBox = page.ContentArea.Controls.OfType<RadGroupBox>().FirstOrDefault(x => x.Name.Contains(question.CategoryId.ToString()));

                var button = groupBox?.Controls.OfType<RadRadioButton>().FirstOrDefault(x => x.IsChecked);
                if (button == null)
                {
                    valid = false;
                    continue;
                }

                Answer answer = (Answer) button.Tag;

                if (question.Ans == answer.AnswerId)
                {
                    score += question.Points;
                }
            }

            if (valid && score > 0)
            {
                _userAccount.UpdatePoints(_userAccount.Points + score);
                MessageBox.Show($"You scored {score} points!");

                RefreshStats();
            }
        }

        private bool IsUnlocked(Apprenticeship apprenticeship)
        {
            if (_userAccount.Points >= apprenticeship.Points)
            {
                return true;
            }

            return false;
        }

        private void RefreshStats()
        {
            this._userAccount = UserAccount.GetAccount(_userAccount.UserId);
            AddApprenticeshipsToList();
            ProcessLeaderboard();
        }

        private void ProcessLeaderboard()
        {
            leaderboardList.Items.Clear();

            foreach (UserAccount userAccount in UserAccount.GetAccountsOrderByPoints())
            {
                leaderboardList.Items.Add(new []
                {
                    userAccount.FirstName + " " + userAccount.LastName,
                    userAccount.Points + " points"
                });
            }
        }
    }
}
