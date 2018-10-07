using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAtm.DAO;

namespace TestAtm.Service
{
    class CardService : ICardService
    {

        private ICardDAO cardDAO;
        public CardService()
        {
            cardDAO = new CardDAO();
        }


        public bool AddCard(string cardNumber, string cvc, string date, string cardCode, double balance)
        {
            if(!string.IsNullOrWhiteSpace(cardNumber) && !string.IsNullOrWhiteSpace(cvc) &&
                !string.IsNullOrWhiteSpace(date) && !string.IsNullOrWhiteSpace(cardCode) &&
                balance >= 0)
            {
                cardDAO.Create(cardNumber, cvc, date, cardCode, balance);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EditCard()
        {

        }

        public bool FindCardNumber(string cardNumber)
        {
            if (!string.IsNullOrWhiteSpace(cardNumber))
            {
                var card = cardDAO.GetCardNumber(cardNumber);
                if(card != null)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            return true;
        }

        public void GetCards()
        {

        }

        public bool RemoveCard(string cardNumber)
        {
            if (!string.IsNullOrWhiteSpace(cardNumber))
            {
                cardDAO.Delete(cardNumber);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FindCardByCode(string cardNumber, string cardCode)
        {
            if(!string.IsNullOrWhiteSpace(cardNumber) && !string.IsNullOrWhiteSpace(cardCode))
            {
                if(cardDAO.GetCardByCode(cardNumber, cardCode) != null){
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
