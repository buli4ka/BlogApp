using AutoMapper;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    class HashTagService
    {
        IRepository<DAL.Context.HashTag> repository;
        IMapper mapper;
        public HashTagService(IRepository<DAL.Context.HashTag> repository)
        {
            this.repository = repository;
            MapperConfiguration configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<DAL.Context.HashTag, DTO.HashTag>();
                x.CreateMap<DTO.HashTag, DAL.Context.HashTag>();
            });
            mapper = new Mapper(configuration);
        }
        public Task<IEnumerable<DTO.HashTag>> GetAll()
        {
            Task<IEnumerable<DTO.HashTag>> task = new Task<IEnumerable<DTO.HashTag>>(() =>
            {
              return mapper.Map<IEnumerable<DAL.Context.HashTag>, IEnumerable<DTO.HashTag>>(repository.GetAll());
            });
            task.Start();
            return task;
        }

        public Task<DTO.HashTag> Get(int id)
        {
            Task<DTO.HashTag> task = new Task<DTO.HashTag>(() =>
            {
                DAL.Context.HashTag entity = repository.Get(id);
                return mapper.Map<DAL.Context.HashTag, DTO.HashTag>(entity);
            });
            task.Start();
            return task;
        }

        public DTO.HashTag Delete(DTO.HashTag item)
        {
            DAL.Context.HashTag entity = repository.Get(item.HashTagId);
            repository.Delete(entity);
            repository.SaveChanges();
            return item;
        }
        public void CreateOrUpdate(DTO.HashTag item)
        {
            DAL.Context.HashTag entity = mapper.Map<DTO.HashTag, DAL.Context.HashTag>(item);
            repository.CreateOrUpdate(entity);
            repository.SaveChanges();
        }
    }
}
