using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizimIs.AdvertisementApp.Dtos;
using BizimIs.AdvertisementApp.Entities;

namespace BizimIs.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class MilitaryStatusProfile : Profile
    {
        public MilitaryStatusProfile()
        {
            CreateMap<MilitaryStatus, MilitaryStatusListDto>().ReverseMap();
        }
    }
}
