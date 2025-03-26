using AutoMapper;
using Blog.EntityLayer.DTO.Articles;
using Blog.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.ServiceLayer.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {

        public ArticleProfile() 
        {
            CreateMap<ArticleDto,Article>().ReverseMap();
        }
    }
}
