using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DigitalProject.Models
{
    public class CategoryInfo
    {
        public List<CategoryInformation> Categories;

        public static CategoryInformation GetCategoryInfo(int categoryId)
        {
            var json = System.IO.File.ReadAllText("CategoryInfo.json");

            var jsonOb = JsonConvert.DeserializeObject<CategoryInfo>(json);

            return jsonOb.Categories.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public static void Init()
        {
            CategoryInfo catInfo = new CategoryInfo()
            {
                Categories = new List<CategoryInformation>
                {
                    new CategoryInformation()
                    {
                        CategoryId = 1,
                        Information = "This is bla bla bla"
                    }
                }
            };

            System.IO.File.WriteAllText("CategoryInfo.json", JsonConvert.SerializeObject(catInfo, Formatting.Indented));
        }
    }

    public class CategoryInformation
    {
        public int CategoryId;

        public string Information;
    }
}
