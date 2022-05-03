using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string CreditCardName { get; set; }
        public string CreditCardOwnerFirstName { get; set; }
        public string CreditCardOwnerLastName { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardType { get; set; } //visa, mastercard, elo, dankort etc. decision with the credit card number
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
        public short Cvv { get; set; }
    }
}
