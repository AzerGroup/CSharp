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
            string month = DateTime.Now.Month.ToString();
            string year = (DateTime.Now.Year + 4).ToString();
            string date = month + "/" + year;
            Console.Write("Enter Card Code    : ");
            string cardCode = Console.ReadLine();
            Console.Write("Enter Card Balance : ");
            double balance =Convert.ToDouble(Console.ReadLine());
            string cardNumber = RandomCardNumber();
            string cvc = RandomCardCvc();

            bool result = cardService.AddCard(cardNumber, cvc, date, cardCode, balance);
            if (result)
            {
                Console.WriteLine($"Card Number      : {cardNumber}");
                Console.WriteLine($"Card CVC         : {cvc}");
                Console.WriteLine($"Card Expire Date : {date}");
                Console.WriteLine("Creating new card is succesfull");
                var key =  Console.ReadKey();
                if(key != null)
                { 
                    Console.Clear();
                }                       
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
                        Console.Clear();
                        Login();
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
        
        public string RandomCardNumber()
        {
            Random random = new Random();
            string cardNumber = "";
            for (int i = 0; i < 4; i++)
            {
                int ran =  random.Next(1000, 9999);
                cardNumber += ran.ToString();
                cardNumber += " ";
            }
            if (cardService.FindCardNumber(cardNumber))
            {
                RandomCardNumber();
            }
            return cardNumber;
        }

        public string RandomCardCvc()
        {
            Random random = new Random();
            string cvc = random.Next(100, 999).ToString();
            return cvc;
        }

        public void Login()
        {

            Console.WriteLine("=======================");
            Console.WriteLine("=        LOGIN        =");
            Console.WriteLine("=======================");

            Console.Write("Enter Card Number : ");
            string oldNumber = Console.ReadLine();
            Console.Write("Enter Card Code   : ");
            string cardCode = Console.ReadLine();
            string cardNumber = "";
            for (int i = 0; i < oldNumber.Length; i++)
            {
                cardNumber += oldNumber[i];
                if(i %4 == 3)
                {
                    cardNumber += " ";
                }
            }
            if (cardService.FindCardByCode(cardNumber, cardCode))
            {
                Console.WriteLine("Access successed");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
    }
}
