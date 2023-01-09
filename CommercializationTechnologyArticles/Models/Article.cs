using System.Xml.Linq;

namespace CommercializationTechnologyArticles.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int InternalIdentifier { get; set; }
        public int ManufacturerIdentifier { get; set; }
    }
}
