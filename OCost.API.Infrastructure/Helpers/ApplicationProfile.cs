using AutoMapper;
using OCost.Core.APIDtos;
using OCost.Core.Constants;
using OCost.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCoast.API.Infrastructure.Helpers
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            //Product
            CreateMap<Product, ProductDto>().ForMember(p => p.Name, opt => opt.MapFrom(opt => Thread.CurrentThread.CurrentCulture.Name.Equals(Languages.English) ? opt.NameEn : opt.NameAr)).ReverseMap();
            CreateMap<Product, CreateUpdateProductDto>().ReverseMap();

        }
    }
}
