using System;

namespace Apbd_miniProject01
{
    public class SerialNumber
    {

        public string FirstPart { get; }
        public char SecondPart { get;}
        public int ThirdPart { get; }

        public SerialNumber()
        {
            FirstPart = "KON";
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            SecondPart = chars[new Random().Next(chars.Length)];
            ThirdPart = new Random().Next(0, 9);
        }
            
    }
}