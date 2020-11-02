using System;
using System.Collections.Generic;
namespace SpinningDiscs
{
    public class CD : BaseClass,IOpticals // IOptical is an interface
    {


        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 


        public CD(string name, int capacity, Dictionary<string,int> contant, string discType) : base(name, capacity, contant, discType)
        {

        }
        public CD(Dictionary<string,int> contant) : base(contant)
        {

        }

        public void ReadData(Dictionary<string, int> contants, string discTypes, string name, int capacity)
        {
            int storageLeft = 0;
            Console.WriteLine("\nDisc Name : " + name);
            Console.WriteLine("\nThe content of CD is: ");
            //Console.WriteLine(" Enter size of the file:");
            //int size = int.Parse(Console.ReadLine());
            foreach (KeyValuePair<string, int> contant in contants)
            {
                storageLeft = storageLeft + contant.Value;
                Console.WriteLine("\n* " + contant.Key + "  -  " + contant.Value);

            }
            Console.WriteLine("\nDiscType: " + discTypes);
            Console.WriteLine("\nDisc Capacity: " + capacity + " MB");
            //capacity = capacity - storageLeft;
            //Console.WriteLine("\n remain capacity: " + capacity);


        }

        public void SpinDisc(string name) //interface method inherite
        {
            Console.WriteLine($"The CD {name}  spins at a rate of 170 - 200 rpm.");
        }



    }
}
