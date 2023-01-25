using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Firma;
using ServiceLayer.DTOs.Order;
using ServiceLayer.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Firm, FirmaDto>().ReverseMap();
            CreateMap<Firm, FirmaEditDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, OrderEditDto>().ReverseMap();
            CreateMap<Product, ProductEditDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
          
        }
    }
}
