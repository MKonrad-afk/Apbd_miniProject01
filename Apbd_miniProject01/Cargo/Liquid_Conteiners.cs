using System;

namespace Apbd_miniProject01
{

    public class Liquid_Conteiners : Container, IHazardNotifier
    {
        CargoType CargoType {get;set; }

        public Liquid_Conteiners(double heightCm, double tareWeightKg, double cargoWeightItself, double depthCm, double maxPayloadKg, CargoType cargoType) 
            : base(heightCm, tareWeightKg, cargoWeightItself, depthCm, maxPayloadKg)
        {
            CargoType = cargoType;
            if (CargoType == CargoType.hazardous)
            {
                MaxPayloadKg = maxPayloadKg / 2;
               
            }
            else
            {
                MaxPayloadKg = maxPayloadKg * 0.9;
            }
        }

        public void violationOfCargoPayload() 
        {
            if (CargoWeightItself > MaxPayloadKg)
            {
                Console.WriteLine($"Dangerous operation reported! Container Serial Number: {SerialNumber}\n" +
                                  $"You want to fiilled Cargo with Violation of the rules - Cargo weight too big!\n" +
                                  $"Max Payload Kg: {MaxPayloadKg}");
                return;
            }
        }

        public void NotifyHazard()
        {
            Console.WriteLine($"Hazardous event reported! Container Serial Number: {SerialNumber}");
        }
    }
}