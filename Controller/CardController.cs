using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAtm.Service;

namespace TestAtm.Controller
{
    class CardController : ICardController
    {
        private ICardService cardService;
        public CardController()
        {
            cardService = new CardService();
        }

        public void CreateCard()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("=      NEW CARD       =");
            Console.WriteLine("=======================");
            Console.Write("Enter Card Number : ");
            string cardNumber = Console.ReadLine();
            Console.Write("Enter CVC         : ");
            string cvc = Console.ReadLine();
            Console.WriteLine("Enter Expire Date : ");
            Console.Write("Enter month : ");
            string month = Console.ReadLine();
            Console.Write("Enter year  : ");
            string year = Console.ReadLine();
            string date = month + "/" + year;
            Console.Write("Enter Card Code    : ");
            string cardCode = Console.ReadLine();
            Console.Write("Enter Card Balance : ");
            double balance =Convert.ToDouble(Console.ReadLine());

            bool result = cardService.AddCard(cardNumber, cvc, date, cardCode, balance);
            if (result)
            {
                Console.WriteLine("Creating new card is succesfull");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Card's information is wrong");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
        }

        public void DeleteCard()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("=     DELETE CARD     =");
            Console.WriteLine("=======================");
            Console.Write("Enter card number : ");
            string cardNumber = Console.ReadLine();
            bool result = cardService.RemoveCard(cardNumber);
            if (result)
            {
                Console.WriteLine("Deleting card is successfull");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Card number format is wrong");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }

        }

        public void Menu()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("=          ATM           =");
            Console.WriteLine("==========================");
            Console.WriteLine("1.LOGIN       ");
            Console.WriteLine("2.NEW CARD    ");
            Console.WriteLine("3.DELETE CARD ");
            Console.WriteLine("4.EXIT        ");
        }

        public void Run()
        {
            while (true)
            {
                Menu();
                Console.Write("Choose operate : ");
                int operate = Convert.ToInt32(Console.ReadLine());
                switch (operate)
                {
                    case 1:

                        break;
                    case 2:
                        Console.Clear();
                        CreateCard();
                        break;
                    case 3:
                        DeleteCard();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Operate is wrong");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }

            }
        }
    }
}
