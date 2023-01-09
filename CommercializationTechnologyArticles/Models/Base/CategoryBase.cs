namespace CommercializationTechnologyArticles.Models
{
    public class CategoryBase
    {
        public CategoryBase(string name, string description)
        {
            Name = name; 
            Description = description;
        }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
