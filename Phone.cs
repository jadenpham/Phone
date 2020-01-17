using System;
using System.Collections.Generic;

namespace Phone
{
    public abstract class Phone
    {
        private string _vNum;
        private int _batteryPerc;
        private string _carrier;
        private string _ringTone;

        public string VNUM {get {return _vNum;}}
        public int batteryPerc {get {return _batteryPerc;}}
        public string carrier {get {return _carrier;}}
        public string ringTone {get {return _ringTone;}}

        public Phone(string vnum, int batperc, string carr, string ringTone)
        {
            _vNum = vnum;
            _batteryPerc = batperc;
            _carrier = carr;
            _ringTone = ringTone;
        }
        public abstract void GetInfo();
    }
}