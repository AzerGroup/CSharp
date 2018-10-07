﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAtm.Classes;

namespace TestAtm.DAO
{
    interface ICardDAO
    {
        void Create(string cardNumber, string cvc, string date, string cardCode, double balance);
        void Read();
        void Update();
        void Delete(string cardNumber);
        Card GetCardNumber(string cardNumber);
        Card GetCardByCode(string cardNumber, string cardCode);
    }
}
