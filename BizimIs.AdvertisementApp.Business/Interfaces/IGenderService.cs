using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizimIs.AdvertisementApp.Dtos;
using BizimIs.AdvertisementApp.Entities;

namespace BizimIs.AdvertisementApp.Business.Interfaces
{
    public interface IGenderService : IService<GenderCreateDto,GenderUpdateDto,GenderListDto,Gender>
    {
    }
}
