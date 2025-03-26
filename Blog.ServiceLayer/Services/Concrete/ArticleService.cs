using AutoMapper;
using Blog.DataLayer.UnitOfWorks;
using Blog.EntityLayer.DTO.Articles;
using Blog.EntityLayer.Entities;
using Blog.ServiceLayer.Services.Abstraction;


namespace Blog.ServiceLayer.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        
        }
        public async Task<List<ArticleDto>> GetAllArticlesAsync()
        {
            var articles =  await _unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = _mapper.Map<List<ArticleDto>>(articles);
            return map;
        }
    }
}
