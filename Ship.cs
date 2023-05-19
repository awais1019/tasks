using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean
{
    public class Ship
    {
        public string SerialNumber;
        public Angle Postion;
    
        public Ship(string serial, Angle postion)
        {
            this.SerialNumber = serial;
            this.Postion= postion;


        }
        public Ship()
        {

        }

        public void printSerialNumber()
        {
            Console.WriteLine("Ship Serial number is" + SerialNumber);
        }
        public void printLongitude()
        {
            Console.WriteLine(Postion.LogitudeDegrees + "\u0b00" + Postion.LogitudeMinutes + Postion.LogitudeDirection);
        }
        public void  printLatitude()
        {
            Console.WriteLine(Postion.LatitudeDegrees + "\u0b00" + Postion.LatitudeMinutes + Postion.LatitudeDirection);
        }
      

    }
}
