using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace SpinningDiscs
{
   public class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            DVD d = new DVD(new Dictionary<string, int>());
            d.Contant.Add("music1", 100);
            d.Contant.Add("music2", 100);
            d.Contant.Add("music3", 200);

            DVD d1 = new DVD("My Movie Collections-", 1700, new Dictionary<string, int>(), "Read/Write"); // dvd instance create

            d1.Contant.Add("I Still know what you did Last Summer", 100);
            d1.Contant.Add("Paranormal", 100);
            d1.Contant.Add("Dance With Me", 100);


            CD c = new CD("Music Audio-Bethoven", 520, new Dictionary<string, int>(), "ReadOnly"); // cd instance create
            c.Contant.Add("music1", 100);
            c.Contant.Add("music2", 100);
            c.Contant.Add("music3", 200);

            // TODO: Call each CD and DVD method to verify that they work as expected.
            while (true)
            {
                Console.WriteLine("\nSelect choice Number: \n");
               
                int displaySelectedChoice = displayChoice();
                if (displaySelectedChoice == 1)
                {

                    // DVD readdata() AND WriteData() interface call
                    d1.ReadData(d1.Contant, d1.DiscType, d1.Name, d1.Capacity);
                }
                else if (displaySelectedChoice == 2)
                {

                    d1.WriteData(d1.Contant, d1.Capacity);
                    Console.WriteLine("Your DVD Burn complete. Press 3 to look into the content.");
                }
                // d1.ReadData(d1.Contant, d1.DiscType, d1.Name, d1.Capacity);


                // CD Readdata() AND WriteData() interface call

                else if (displaySelectedChoice == 3)
                {
                    c.ReadData(c.Contant, c.DiscType, c.Name, c.Capacity);
                }
                else if (displaySelectedChoice == 4)
                {
                    d1.SpinDisc(d1.Name);
                }else if(displaySelectedChoice == 5)
                {
                    c.SpinDisc(c.Name);

                }
                else if (displaySelectedChoice == 6)
                {
                    Console.Write("Do you want to EXIT from quiz? (Yes/No): ");
                    string yesOrNO = Console.ReadLine();
                    if (yesOrNO.ToLower() == "yes")
                    {
                        Console.WriteLine("--------------------GOODBYE----------------------------------");
                      
                        break;
                    }
                }




                //c.ReadData(c.Contant, c.DiscType, c.Name, c.Capacity);


            }
        }
        public static int displayChoice() // populated Menu for all type
        {
            bool validChoice = true;
            int selectedChoice;
            do
            {

                Console.WriteLine("\n--------------------------\n ");
                Console.WriteLine("1) Read DVD  \n ");
                Console.WriteLine("2) Write DVD \n ");
                Console.WriteLine("3) Read CD   \n");
                Console.WriteLine("4) Spin DVD  \n");
                Console.WriteLine("5) Spin CD  \n");
                Console.WriteLine("6) Exit  \n");

                Console.WriteLine("\n--------------------------\n ");

                string input = Console.ReadLine();

                selectedChoice = int.Parse(input);


                if (selectedChoice < 0 || selectedChoice > 6)
                {
                    Console.WriteLine("Invalid Choice.");

                }
                else
                {
                    validChoice = false;
                }


            } while (validChoice);


           



            return selectedChoice;
        }

    }

   


}
