namespace CommercializationTechnologyArticles.Models
{
    public class Category : CategoryBase
    {
        public Category(string name, string description) : base(name, description)
        {

        }

        public int CategoryId { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
