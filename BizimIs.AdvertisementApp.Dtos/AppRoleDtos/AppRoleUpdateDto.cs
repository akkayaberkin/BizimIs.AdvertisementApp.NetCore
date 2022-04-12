using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizimIs.AdvertisementApp.Dtos.Interfaces;

namespace BizimIs.AdvertisementApp.Dtos.AppRoleDtos
{
    public class AppRoleUpdateDto : IUpdateDto
    {
        public int Id { get; set; }

        public string Definition { get; set; }
    }
}
