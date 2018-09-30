using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAtm.Classes;

namespace TestAtm.DAO
{
    class CardDAO : ICardDAO
    {
        private List<Card> listCards;

        public CardDAO()
        {
            listCards = new List<Card>();
        }

        public void Create(string cardNumber, string cvc, string date, string cardCode, double balance)
        {
            //create card
            Card card = new Card(cardNumber, cvc, date, cardCode, balance);

            //add card to list
            listCards.Add(card);
        }

        public void Delete(string cardNumber)
        {
            //find card
            var card = listCards.Find(x => x.CardNumber == cardNumber);

            //delete card
            listCards.Remove(card);
        }

        public void Read()
        {

        }

        public void Update()
        {

        }
    }
}
