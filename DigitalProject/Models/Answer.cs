using System.Collections.Generic;
using System.Windows.Forms;
using SqlKata.Execution;

namespace DigitalProject.Models
{
    class Answer : Question
    {
        public int AnswerId;

        public int QuestionId;

        public string answer;

        public static IEnumerable<Answer> GetAnswers(int questionId)
        {
            var query = DatabaseManager.QueryFactory.Query("Answers").Join("Questions", "Answers.questionid", "Questions.questionid")
                .Where("Questions.questionid", questionId).Get<Answer>();

            return query;
        }
    }
}
