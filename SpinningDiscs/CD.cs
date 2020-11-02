using System;
using System.Collections.Generic;
namespace SpinningDiscs
{
    public class CD : BaseClass
    {
        public CD(string v1, string v2)
        {
            V1 = v1;
            V2 = v2;
        }

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 

        public CD(string name, Dictionary<string, string> contant, int capacity, string discType): base( name, contant, capacity, discType)
        {
           
            
            //discType = discType;
        }

        public string V1 { get; }
        public string V2 { get; }
    }
}
