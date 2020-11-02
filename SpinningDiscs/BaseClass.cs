using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
  public abstract class BaseClass
    {
        public string Name{ get; set;}
        public  Dictionary<string,int> Contant { get; set; }
        public int Capacity { get;  }
        public string DiscType { get; }
       public int StorageLeft { get; set; }
        public BaseClass(string name, int capacity, Dictionary<string,int> contant, string discType)
        {
            Name = name;
            Contant = contant;
            Capacity = capacity;
            DiscType = discType;
          


        }

        public BaseClass(Dictionary<string,int> contant)
        {
            Contant = new Dictionary<string, int>();
        }

        //public abstract  string StoreData(BaseClass baseClass)
        //{

        //}

    }


}
