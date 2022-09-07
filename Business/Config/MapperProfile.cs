using AutoMapper;
using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<About, AboutDTO>();
            CreateMap<AboutDTO, About>();

            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();

            CreateMap<Contact, ContactDTO>();
            CreateMap<ContactDTO, Contact>();

            CreateMap<Job, JobDTO>();
            CreateMap<JobDTO, Job>();

            CreateMap<Message, MessageDTO>();
            CreateMap<MessageDTO, Message>();

        }
    }
}
