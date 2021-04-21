using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Repositories;

namespace BLL.Services
{
    class ArticleService
    {
        IRepository<DAL.Context.Article> repository;
        IMapper mapper;
        public ArticleService(IRepository<DAL.Context.Article> repository)
        {
            this.repository = repository;
            MapperConfiguration configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<DAL.Context.Article, DTO.Article>()
                .ForMember(y => y.ViewCount, y => y.MapFrom(source => source.ViewedUsers.Count))
                .ForMember(y => y.LikesCount, y => y.MapFrom(source => source.LikedUsers.Count));

                x.CreateMap<DAL.Context.HashTag, DTO.HashTag>();
                x.CreateMap<DTO.HashTag, DAL.Context.HashTag>();

                x.CreateMap<DTO.Article, DAL.Context.Article>();
            });
            mapper = new Mapper(configuration);
        }
        public Task<IEnumerable<DTO.Article>> GetAll()
        {
            Task<IEnumerable<DTO.Article>> task = new Task<IEnumerable<DTO.Article>>(() =>
            {
                return mapper.Map<IEnumerable<DAL.Context.Article>, IEnumerable<DTO.Article>>(repository.GetAll());
            });
            task.Start();
            return task;
        }

        public Task<DTO.Article> Get(int id)
        {
            Task<DTO.Article> task = new Task<DTO.Article>(() =>
            {
                DAL.Context.Article entity = repository.Get(id);
                return mapper.Map<DAL.Context.Article, DTO.Article>(entity);
            });
            task.Start();
            return task;
        }

        public DTO.Article Delete(DTO.Article item)
        {
            DAL.Context.Article entity = repository.Get(item.ArticleId);
            repository.Delete(entity);
            repository.SaveChanges();
            return item;
        }
        public void CreateOrUpdate(DTO.Article item)
        {
            DAL.Context.Article entity = mapper.Map<DTO.Article, DAL.Context.Article>(item);
            repository.CreateOrUpdate(entity);
            repository.SaveChanges();
        }
    }
}
