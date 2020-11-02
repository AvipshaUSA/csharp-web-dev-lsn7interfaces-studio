using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
  public  class BaseClass
    {
        public string Name{ get; set;}
        public  Dictionary<string, string> Contant { get; set; }
        public int Capacity { get;  }
        public string DiscType { get; } 

        public BaseClass(string name, Dictionary<string,string> contant, int capacity, string discType )
        {
            Name = name;
            Contant = contant;
            Capacity = capacity;
            DiscType = discType;



        }
        public BaseClass()
        {
            Contant = new Dictionary<string, string>();
        }
        

        //public abstract  string StoreData(BaseClass baseClass)
        //{

        //}

    }


}
