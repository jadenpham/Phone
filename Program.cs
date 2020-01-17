using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Samsung s10 = new Samsung("Galaxy S10", 100, "T-Mobile", "You got a call, BITCH");
            Nokia oldie = new Nokia("Oldie Phone", 110, "Verizon", "BEEP BEEP");

            s10.GetInfo();
            System.Console.WriteLine(s10.Ring());
            System.Console.WriteLine(s10.Unlock());
            System.Console.WriteLine("");

            oldie.GetInfo();
            System.Console.WriteLine(oldie.Ring());
            System.Console.WriteLine(oldie.Unlock());
        }
    }
}
