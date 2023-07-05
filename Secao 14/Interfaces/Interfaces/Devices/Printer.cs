using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Devices
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }

    }
}
