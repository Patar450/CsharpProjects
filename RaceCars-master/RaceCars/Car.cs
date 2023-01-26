using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceCars
{
    internal class Car
    {
        private int TotalOdometers;
        private int SpeedInMph;
        private string driverName;
        private string Sponsor;
        private int carNumber;

        public int totalOdometers
        { 
            get { return TotalOdometers; } 
            set { TotalOdometers = value; } 
        }

        public int speedInMph 
        { 
            get { return SpeedInMph; } 
            set { SpeedInMph = value; } 
        }
        public string dName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public string sponsor
        {
            get { return Sponsor; }
            set { Sponsor = value; }
        }

        public int CarNumber
        {
            get { return carNumber; }
            set { carNumber = value; }
        }

        public Car(int to, int sp, string dn, string sps, int cn)
        {
            TotalOdometers = to;
            SpeedInMph = sp;
            driverName = dn;
            Sponsor = sps;
            CarNumber = cn;
        }

        public Car()
        {
            TotalOdometers=0;
            SpeedInMph=0;
            driverName = null;
            Sponsor = null;
            CarNumber = 0;
        }
    }
}
