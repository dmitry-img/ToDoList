using Application.DTOs.ToDoItem;
using Application.DTOs.ToDoList;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ToDoItemEntity, ToDoItemDto>().ReverseMap();
            CreateMap<ToDoListEntity, ToDoListDto>()
                .ForMember(
                entity => entity.Items,
                dto => dto.MapFrom(d => d.Items)).ReverseMap();

            CreateMap<ToDoItemEntity, CreateToDoItemDto>().ReverseMap();
            CreateMap<ToDoListEntity, CreateToDoListDto>().ReverseMap();

            CreateMap<ToDoItemEntity, UpdateToDoItemDto>().ReverseMap();
            CreateMap<ToDoListEntity, UpdateToDoListDto>().ReverseMap();

            CreateMap<ToDoItemEntity, UpdateToDoItemPriorityLevelDto>().ReverseMap();
            

        }
    }
}
