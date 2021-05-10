using AIGProject.Domain.Entities;
using AIGProject.WebUI.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIGProject.WebUI.Helpers
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            //Bidirectional mapping of Product and ProductViewModel
            CreateMap<Product, ProductViewModel>()
                ;
            CreateMap<ProductViewModel, Product>()
                ;
        }
    }
}
