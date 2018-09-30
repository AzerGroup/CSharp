using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAtm.Controller;

namespace TestAtm
{
    class Program
    {
        static void Main(string[] args)
        {
            ICardController cardController = new CardController();
            cardController.Run();
        }
    }
}
