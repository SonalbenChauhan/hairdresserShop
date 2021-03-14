using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hairdresserShop
{
    public enum Customer
    {
        Gentlemen = 1,
        Ladies=2,
        Children=3,
       
    }
    class Program
    {
        List<string> appointmentSlot = new List<string>();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
            Console.ReadKey();
        }


        public void Run()
        {
            AppointmentList myList = new AppointmentList();

            appointmentSlot.Add("9AM to 10AM ");
            appointmentSlot.Add("10AM to 11AM ");
            appointmentSlot.Add("11AM to 12PM ");
            appointmentSlot.Add("12PM to 01PM ");
            appointmentSlot.Add("01PM to 02PM ");
            appointmentSlot.Add("02PM to 03PM ");
            appointmentSlot.Add("03PM to 04PM ");
            appointmentSlot.Add("04PM to 05PM ");
            appointmentSlot.Add("05PM to 06PM ");

            string input = string.Empty;
            do
            {
                string name = string.Empty;

                bool invalidInput = true;

                do
                {
                    Console.Write("Enter name: ");
                    name = Console.ReadLine();
                    if (name.Length > 0)
                    {
                        invalidInput = false;
                    }
                    else
                    {
                        Console.WriteLine("Name length should be greater than 0");
                    }


                } while (invalidInput);



                int age = 0;
                string ageString = string.Empty;

                invalidInput = true;

                do
                {
                    Console.Write("Enter age[1-99]: ");
                    ageString = Console.ReadLine();
                    if (int.TryParse(ageString, out age) && age > 0 && age <= 99)
                    {
                        invalidInput = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }

                } while (invalidInput);

                int height = 0;
                string heightString = string.Empty;
                do
                {
                    Console.Write("Enter height in inches[10-96]: ");
                    heightString = Console.ReadLine();
                } while (!(int.TryParse(heightString, out height) && height >= 10 && height <= 96));

                string creditCard = string.Empty;
                creditCard = addCreditCard();

                int customerType = 0;
                string stringClient = string.Empty;

                do
                {
                    Console.Write("Enter Customer type (1) for Gentlemen, (2) for Ladies, (3)for Children : ");
                    stringClient = Console.ReadLine();
                } while (!(int.TryParse(stringClient, out customerType) && customerType >= (int)Customer.Gentlemen
                                && customerType <= (int)Customer.Children));

                Client client = null;
                switch (customerType)
                {
                    case (int)Customer.Gentlemen:
                        client = new Gentlemen() { Name = name, Height = height, Age = age, CreditCardNumber = creditCard };

                        string trim = string.Empty;

                        do
                        {
                            Console.Write("Does Gentleman need Trimming?[Y/N]");
                            trim = Console.ReadLine();
                        } while (trim.Length != 1 || (trim.ToUpper() != "Y" && trim.ToUpper() != "N"));

                        ((Gentlemen)client).IsTrimmingNeeded = (trim.ToUpper() == "Y") ? true : false;



                        string moustache = string.Empty;
                        do
                        {
                            Console.Write("Does Gentleman need to do moustaches?[Y/N]");
                            moustache = Console.ReadLine();
                        } while (moustache.Length != 1 || (moustache.ToUpper() != "Y" && moustache.ToUpper() != "N"));
                        ((Gentlemen)client).Moustaches = (moustache.ToUpper() == "Y") ? true : false;
                        client.Slot = selectAppoinmentSlot();
                        break;

                    case (int)Customer.Ladies:
                        client = new Ladies() { Name = name, Height = height, Age = age, CreditCardNumber = creditCard };

                        string hairStyle = string.Empty;
                        do
                        {
                            Console.Write("Need hairstyle?[Y/N]");
                            hairStyle = Console.ReadLine();
                        } while (hairStyle.Length != 1 || (hairStyle.ToUpper() != "Y" && hairStyle.ToUpper() != "N"));
                        ((Ladies)client).HairStyle = (hairStyle.ToUpper() == "Y") ? true : false;
                        client.Slot = selectAppoinmentSlot();
                        break;

                    case (int)Customer.Children:
                        client = new Children() { Name = name, Height = height, Age = age, CreditCardNumber = creditCard };

                        string sensitiveTrimmers = string.Empty;
                        do
                        {
                            Console.Write("Sensitive Trimmer? [Y/N]");
                            sensitiveTrimmers = Console.ReadLine();
                        } while (sensitiveTrimmers.Length != 1 || (sensitiveTrimmers.ToUpper() != "Y" && sensitiveTrimmers.ToUpper() != "N"));
                        ((Children)client).SensitiveTrimmers = (sensitiveTrimmers.ToUpper() == "Y") ? true : false;
                        string adjustableSeats = string.Empty;
                        do
                        {
                            Console.Write("Does child require adjustale seat? [Y/N]");
                            adjustableSeats = Console.ReadLine();
                        } while (adjustableSeats.Length != 1 || (adjustableSeats.ToUpper() != "Y" && adjustableSeats.ToUpper() != "N"));
                        ((Children)client).AdjustableSeats = (adjustableSeats.ToUpper() == "Y") ? true : false;
                        client.Slot = selectAppoinmentSlot();
                        break;
                }

                myList.Add(client);

                Console.Write("Do you want to enter more? [Y/N] ");
                input = Console.ReadLine();
            } while (input.Length == 0 || input.Length > 1 || input.ToUpper() == "Y" || input.ToLower() == "y");
            myList.Sort();

            foreach (Client v in myList)
            {
                Console.WriteLine(v);

                v.Services();
                v.OtherService();
            }

        }
        private string selectAppoinmentSlot()
        {
            int slotNumber = 0;
            string slotString = string.Empty;
            string slot = string.Empty;
            do
            {
                Console.WriteLine("Select available slot[1-{0}] ", appointmentSlot.Count);
                for (int i = 0; i < appointmentSlot.Count; i++)
                {
                    Console.WriteLine("{0} => {1}", i + 1, appointmentSlot[i]);
                }

                slotString = Console.ReadLine();

            } while (!(int.TryParse(slotString, out slotNumber) && slotNumber >= 1 && slotNumber <= appointmentSlot.Count));

            //slot selected
            slot = appointmentSlot[slotNumber - 1];

            //booked appointment remove from available slots
            appointmentSlot.Remove(slot);

            return slot;


        }
        private string addCreditCard()
        {
            string creditCard = string.Empty;
            bool isInCorrect = true;
            do
            {
                Console.Write("Enter creditcard number : ");


                creditCard = Console.ReadLine();
                if (creditCard != string.Empty && creditCard != null && creditCard.Length == 16)
                {

                    char[] cardArray = creditCard.ToCharArray();

                    foreach (char c in cardArray)
                    {
                        if (!char.IsDigit(c))
                        {
                            isInCorrect = true;

                            break;
                        }
                    }
                    isInCorrect = false;


                }

                if (isInCorrect)
                {
                    Console.WriteLine("Invalid credit card!");
                }


            } while (isInCorrect);
            return creditCard;

        }

    }
}
