using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizimIs.AdvertisementApp.Dtos.Interfaces;

namespace BizimIs.AdvertisementApp.Dtos
{
    public class GenderCreateDto : IDto
    {
        public string Definition { get; set; }
    }
}
