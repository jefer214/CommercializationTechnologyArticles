namespace CommercializationTechnologyArticles.Services.Article
{
    using CommercializationTechnologyArticles.Entities.Requests;
    using CommercializationTechnologyArticles.Models;
    public interface IArticleService
    {
        Task<IEnumerable<Article>> GetArticlesByCategoryOrSubCategory(GetArticlesRequest request);
    }
}
