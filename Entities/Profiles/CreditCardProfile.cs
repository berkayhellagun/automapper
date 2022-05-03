using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profiles
{
    public class CreditCardProfile : Profile //inherit from automapper
    {
        public CreditCardProfile()
        {
            CreateMap<CreditCard, CreditCardDto>()
                .ForMember(dest => dest.CreditCardOwnerName,
                           act => act.MapFrom(src => src.CreditCardOwnerFirstName + " " + src.CreditCardOwnerLastName))
                .ForMember(dest => dest.ExpirationDate, act => act.MapFrom(src => src.ExpirationMonth + "/" + src.ExpirationYear))
                .ForMember(dest => dest.CardName, act => act.MapFrom(src => src.CreditCardName));
        }
    }
}
