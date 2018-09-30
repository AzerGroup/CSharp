using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAtm.Controller
{
    interface ICardController
    {
        void CreateCard();
        void DeleteCard();
        void Run();
        void Menu();
    }
}
