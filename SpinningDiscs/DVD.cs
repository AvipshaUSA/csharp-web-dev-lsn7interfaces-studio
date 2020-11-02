using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace SpinningDiscs
    
{
    public class DVD : BaseClass, IOpticals
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        public DVD(string name, int capacity, Dictionary<string,int> contant, string discType) : base(name, capacity,contant, discType)
        {

        }
        public DVD (Dictionary<string,int> contant) : base(contant)
        {

        }

        public  void ReadData(Dictionary<string, int> contants, string discTypes, string name, int capacity)
        {
            int storageLeft = 0;
            Console.WriteLine("\nDisc Name : " + name);
            Console.WriteLine("\nThe content of DVD is: ");
            //Console.WriteLine(" Enter size of the file:");
            //int size = int.Parse(Console.ReadLine());
            foreach (KeyValuePair<string,int> contant in contants)
            {
                storageLeft = storageLeft + contant.Value;
               Console.WriteLine("\n* " + contant.Key+ "  -  " + contant.Value);

            }
            Console.WriteLine("\nDiscType: " + discTypes);
            Console.WriteLine("\nDisc Capacity: " + capacity+ " MB");
            capacity = capacity - storageLeft;
            Console.WriteLine("\n remain capacity: " + capacity);
            
            
        }

        public  void WriteData(Dictionary<string,int> contants, int capacity)
        {
            Console.WriteLine("\nWrite in your DVD:");
            string input = Console.ReadLine();
            Console.WriteLine("\n Enter size of the file:");
            int size = int.Parse(Console.ReadLine());
            contants.Add(input,size);
            
            //capacity = capacity - size;
            //return capacity;

        }
       
            public void SpinDisc(string name) // interface method inherite
            {
                Console.WriteLine($"The DVD {name}  spins at a rate of 570 - 1600 rpm.");
            }
        

    }
}
