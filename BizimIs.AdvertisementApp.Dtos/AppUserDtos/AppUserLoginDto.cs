using BizimIs.AdvertisementApp.Dtos.Interfaces;

namespace BizimIs.AdvertisementApp.Dtos
{
    public class AppUserLoginDto : IDto
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
