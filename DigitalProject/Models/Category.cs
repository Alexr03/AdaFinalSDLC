using System.Collections.Generic;
using System.Windows.Forms;
using SqlKata.Execution;

namespace DigitalProject.Models
{
    class Category
    {
        public int CategoryId;
        
        public string CategoryName;

        public string Description;

        public static IEnumerable<Category> GetCategories()
        {
            return DatabaseManager.QueryFactory.Query("Category").Get<Category>();
        }
    }
}
