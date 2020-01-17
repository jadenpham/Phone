using System;
using System.Collections.Generic;

namespace Phone
{
    class Nokia : Phone, IRing
    {
        public Nokia(string vnum, int batperc, string carr, string ringTone): base(vnum, batperc, carr, ringTone){}

        public string Ring()
        {
            return ringTone;
        }
        public string Unlock()
        {
            return "You've unlocked your Nokia";
        }

        public override void GetInfo()
        {
            System.Console.WriteLine($"Version: {VNUM}");
            System.Console.WriteLine($"Percentage: {batteryPerc}");
            System.Console.WriteLine($"Carrier: {carrier}.");
            System.Console.WriteLine($"Ring Tone: {ringTone}"); 
        }
    }

    class Samsung: Phone, IRing
    {
        public Samsung(string vnum, int batperc, string carr, string ringTone): base(vnum, batperc, carr, ringTone){}

        public string Ring()
        {
            return ringTone;
        }
        public string Unlock()
        {
            return "Scanned fingerprint succesfully. Samsung unlocked";
        }
        public override void GetInfo()
        {
            System.Console.WriteLine($"Version: {VNUM}");
            System.Console.WriteLine($"Percentage: {batteryPerc}");
            System.Console.WriteLine($"Carrier: {carrier}.");
            System.Console.WriteLine($"Ring Tone: {ringTone}"); 
        }
    }
}