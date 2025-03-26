using Blog.EntityLayer.DTO.Articles;

namespace Blog.ServiceLayer.Services.Abstraction
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesAsync();

    }
}
