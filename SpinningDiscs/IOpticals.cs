using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticals
    {
        void ReadData(Dictionary<string,int> contants, string discTypes, string name, int capacity);
        //void WriteData(Dictionary<string, int> contants, int capacity);
        void SpinDisc(string name);
    }
}
