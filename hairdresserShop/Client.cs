using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hairdresserShop
{
    public delegate void ShopServices();
   public abstract class Client : IClient,IComparable

    {
        private string name;
        private int age;
        private decimal height;
        private string creditCardNumber;
        private string slot;
        private ShopServices services;


        

        public int Age { get => age; set => age = value; }
        public decimal Height { get => height; set => height = value; }
        public string CreditCardNumber { get => creditCardNumber; set => creditCardNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Slot { get => slot; set => slot = value; }
        public ShopServices Services { get => services; set => services = value; }

        public Client()
        {
            services = HairWash;
            services += HairTrim;
            services += HairDye;


        }

        public void HairWash()
        {
            Console.WriteLine("Hair Wash");
        }

        public void HairTrim()
        {
            Console.WriteLine("Hair Trim");
        }

        public void HairDye()
        {
            Console.WriteLine("Hair Dye");
        }
        public abstract void OtherService();



        public override string ToString()
        {

            char[] cardNumber = creditCardNumber.ToCharArray();
            string card = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 16; i++) {
                 if (i >= 4 && i <= 11)
                {
                    stringBuilder.Append('X');
                }
                else {
                    stringBuilder.Append(cardNumber[i]);
                }

                if (i == 3 || i == 7 || i == 11) {
                    stringBuilder.Append(' ');
                }

            }
            
          

            return string.Format("Age of client: {0}, Name of client: {1}, Height of client: {2}, Credit card number of client: {3} and appointment booked for {4}.\n", age,name, height, stringBuilder,slot);
        } 

        public int CompareTo(object obj)
        {
            Client c = (Client)obj;

            return this.age.CompareTo(c.age);


        }

    }
}
