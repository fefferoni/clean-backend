using AutoMapper;
using CleanBackend.Application.Models;
using CleanBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanBackend.Application.MappingProfiles
{
    public class ItemMappingProfile : Profile
    {
        public ItemMappingProfile()
        {
            CreateMap<Item, ItemModel>();
            CreateMap<Commands.CreateItemCommand, Item>();
        }
    }
}
