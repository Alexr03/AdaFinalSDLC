using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlKata.Execution;

namespace DigitalProject.Models
{
    class Question : Category
    {
        public int QuestionId;

        public int CategoryId;

        public string question;

        public int Ans;

        public int Points;

        public static IEnumerable<Question> GetQuestions()
        {
            return DatabaseManager.QueryFactory.Query("Category").Get<Question>();
        }

        public static IEnumerable<Question> GetQuestions(int categoryId)
        {

            return DatabaseManager.QueryFactory.Query("Questions").Join("Category", "Category.categoryid", "Questions.categoryid").Where("Questions.categoryid", categoryId)
                .Get<Question>();
        }
    }
}
