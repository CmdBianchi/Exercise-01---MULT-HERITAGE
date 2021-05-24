using System;
using Devices;
namespace Exercise_01___MULT_HERITAGE {
    //-----> START
    ///////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2023 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
