using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAtm.Classes
{
    class Card
    {
        private string cardNumber;
        private string cvc;
        private string date;
        private string cardCode;
        private double balance;

        public string CardNumber
        {
            get
            {
                return cardNumber;
            }
            set
            {
                cardNumber = value;
            }
        }
        public string Cvc
        {
            get
            {
                return cvc;
            }
            set
            {
                cvc = value;
            }
        }
        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        public string CardCode
        {
            get
            {
                return cardCode;
            }
            set
            {
                cardCode = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public Card(string cardNumber, string cvc, string date, string cardCode, double balance)
        {
            CardNumber = cardNumber;
            Cvc = cvc;
            Date = date;
            CardCode = cardCode;
            Balance = balance;
        }

    
    }
}
