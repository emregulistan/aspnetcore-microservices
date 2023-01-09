using AutoMapper;
using Basket.API.Entities;
using Eventbus.Messages.Events;

namespace Basket.API.Mapper
{
    public class BasketProfile : Profile
    {
        public BasketProfile() 
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }

    }
}
