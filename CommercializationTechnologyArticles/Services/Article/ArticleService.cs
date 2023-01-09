namespace CommercializationTechnologyArticles.Services.Article
{
    using CommercializationTechnologyArticles.Data;
    using CommercializationTechnologyArticles.Entities.Requests;
    using CommercializationTechnologyArticles.Models;
    using System.Linq;
    using System.Threading.Tasks;

    public class ArticleService : IArticleService
    {
        private readonly DataContext _context;

        public ArticleService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Article>> GetArticlesByCategoryOrSubCategory(GetArticlesRequest request)
        {
            List<Article> articles = new();

            try
            {
                if (request.CategoryId != 0)
                {
                    articles = (from art in _context.Articles
                                from cate in _context.ArticlesInCategories.Where(c => c.CategoryId == request.CategoryId)
                                where art.Id == cate.ArticleId
                                select art).Distinct().ToList();
                }

                if (request.SubCategoryId != 0)
                {
                    articles = (from art in _context.Articles
                                from cate in _context.ArticlesInCategories.Where(c => c.SubCategoryId == request.SubCategoryId)
                                where art.Id == cate.ArticleId
                                select art).Distinct().ToList();
                }

                return articles.Skip(request.Page - 1).Take(request.NumberRecords);
            }
            catch (Exception ex)
            {
                return articles;
            }
        }
    }
}
