using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Automap.Controllers
{
    [Route("api/creditcard")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly IMapper _mapper;

        public CreditCardController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost("post")]
        public IActionResult Post(CreditCard creditCard)
        {
            var creditCardInfo = _mapper.Map<CreditCardDto>(creditCard);
            if (creditCardInfo == null)
            {
                return BadRequest();
            }
            return Ok(creditCardInfo.CreditCardOwnerName + " " + creditCardInfo.ExpirationDate);
        }
    }
}
