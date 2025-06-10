using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStuff
{
    internal interface IAnmial
    {
        bool IsPet { get; set; }
        bool DoesMate { get; set; }
        int NumberOfEyes { get; set; }
        DateTime DateDiscovered { get; set; }

        string Type { get; set; }
    }
}
