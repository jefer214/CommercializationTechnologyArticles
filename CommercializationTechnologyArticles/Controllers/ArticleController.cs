namespace CommercializationTechnologyArticles.Controllers
{
    using CommercializationTechnologyArticles.Entities.Requests;
    using CommercializationTechnologyArticles.Models;
    using CommercializationTechnologyArticles.Services.Article;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpPost]
        public async Task<IActionResult> GetArticlesByCategoryOrSubCategoria(GetArticlesRequest request)
        {
            IEnumerable<Article> result =  await _articleService.GetArticlesByCategoryOrSubCategory(request).ConfigureAwait(false);

            if (!result.Any())
            {
                return NotFound("No se han encontrado artículos con los parámetros ingresados");
            }

            return Ok(result);
        }
    }
}
