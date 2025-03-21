using System;

namespace Apbd_miniProject01
{
    public class Gas_Containers : Container, IHazardNotifier
    {
        public double Pressure { get; private set; }

        public Gas_Containers( double heightCm, double tareWeightKg, double depthCm, double maxPayloadKg, double pressure) 
            : base(heightCm, tareWeightKg, depthCm, maxPayloadKg)
        {
            Pressure = pressure;
        }

        public override void emptyCargo()
        {
            if (CargoWeightItself.Equals(0))
            {
                Console.WriteLine("Cargo is already empty");
            }
            else
            {
                MassKg = TareWeightKg;
                CargoWeightItself = CargoWeightItself * 0.05;
                
            }
        }

        public void checkPayload()
        {
            if (MassKg > MaxPayloadKg)
            {
                throw new OverfillException();
            }

            
        }

        public void NotifyHazard()
        {
            Console.WriteLine($"Hazardous event reported! Container Serial Number: {SerialNumber}");
        }
    }
}