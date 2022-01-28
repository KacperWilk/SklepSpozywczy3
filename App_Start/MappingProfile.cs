using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SklepSpozywczy3.Dtos;
using SklepSpozywczy3.Models;

namespace SklepSpozywczy3.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Product, ProductDto>();
            Mapper.CreateMap<ProductDto, Product>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<CategoryType, CategoryTypeDto>();
        }
    }
}