using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DAL.Entities;
using TWS.Model;

namespace TWS.Repository
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<ManufacturerEntity, Manufacturer>();
            CreateMap<Manufacturer, ManufacturerEntity>().ForMember(e => e.Products, opt => opt.Ignore());
            CreateMap<ProductEntity, Product>();
            CreateMap<Product, ProductEntity>();
        }
    }
}
