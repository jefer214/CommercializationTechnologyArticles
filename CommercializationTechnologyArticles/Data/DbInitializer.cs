using CommercializationTechnologyArticles.Models;

namespace CommercializationTechnologyArticles.Data
{
    public class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (context.Categories.Any())
            {
                return; 
            }

            Category[] categories = new Category[]
            {
                new Category("Computo", "Categoría Computo") { CategoryId = 1 },
                new Category("Audio", "Categoría Audio") { CategoryId = 2 }
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();

            SubCategory[] subCategories = new SubCategory[]
            {
                new SubCategory("Laptops", "Computadores personales") { SubCategoryId = 1 },
                new SubCategory("Parlantes", "Parlantes para pc") { SubCategoryId = 2 }
            };

            context.SubCategories.AddRange(subCategories);
            context.SaveChanges();
        }
    }
}
