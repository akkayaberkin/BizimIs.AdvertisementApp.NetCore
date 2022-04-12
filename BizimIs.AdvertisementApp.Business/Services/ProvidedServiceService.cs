using AutoMapper;
using FluentValidation;
using BizimIs.AdvertisementApp.Business.Interfaces;
using BizimIs.AdvertisementApp.DataAccess.UnitOfWork;
using BizimIs.AdvertisementApp.Dtos;
using BizimIs.AdvertisementApp.Entities;

namespace BizimIs.AdvertisementApp.Business.Services
{
    public class ProvidedServiceService : Service<ProvidedServiceCreateDto,ProvidedServiceUpdateDto,ProvidedServiceListDto,ProvidedService>,IProvidedServiceService
    {
        public ProvidedServiceService(IMapper mapper, IValidator<ProvidedServiceCreateDto> createDtoValidator,IValidator<ProvidedServiceUpdateDto> updateDtoValidator,IUow uow) : base(mapper,createDtoValidator,updateDtoValidator,uow)
        {
        }

    }
}
