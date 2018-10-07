using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAtm.Service
{
    interface ICardService
    {
        bool AddCard(string cardNumber, string cvc, string date, string cardCode, double balance);
        bool RemoveCard(string cardNumber);
        void EditCard();
        void GetCards();
        bool FindCardNumber(string cardNumber);
        bool FindCardByCode(string cardNumber, string cardCode);
    }
}
