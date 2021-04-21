using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Repositories;

namespace BLL.Services
{
    class UserService
    {
        IRepository<DAL.Context.User> repository;
        IMapper mapper;
        public UserService(IRepository<DAL.Context.User> repository)
        {
            this.repository = repository;
            MapperConfiguration configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<DAL.Context.User, DTO.User>();
                x.CreateMap<DTO.User, DAL.Context.User>();

                x.CreateMap<DAL.Context.Article, DTO.Article>()
               .ForMember(y => y.ViewCount, y => y.MapFrom(source => source.ViewedUsers.Count))
               .ForMember(y => y.LikesCount, y => y.MapFrom(source => source.LikedUsers.Count));

                x.CreateMap<DAL.Context.HashTag, DTO.HashTag>();
                x.CreateMap<DTO.HashTag, DAL.Context.HashTag>();

                x.CreateMap<DTO.Article, DAL.Context.Article>();
            });
            mapper = new Mapper(configuration);
        }

    }
}
