using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CreditCardDto
    {
        public string CardName { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardOwnerName { get; set; }
        public string ExpirationDate { get; set; }
        public short Cvv { get; set; }
    }
}
