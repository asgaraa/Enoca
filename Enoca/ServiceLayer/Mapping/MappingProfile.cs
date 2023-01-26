using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Firma;
using ServiceLayer.DTOs.Order;
using ServiceLayer.DTOs.Product;

namespace ServiceLayer.Mapping
{
	public class MappingProfile : Profile
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
