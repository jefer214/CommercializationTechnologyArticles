namespace CommercializationTechnologyArticles.Models
{
    public class SubCategory : CategoryBase
    {
        public SubCategory(string name, string description) : base(name, description)
        {

        }

        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
    }
}
