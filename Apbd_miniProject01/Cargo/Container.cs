using System;
using Microsoft.Ajax.Utilities;

namespace Apbd_miniProject01
{
    public class Container
    {
        //sum of the weight
        public double MassKg { get;  set; }
        //cargo weight
        public double CargoWeightItself { get;  set; }
        //container weight
        public double TareWeightKg { get;  set; }
        //how much we can load
        public double MaxPayloadKg { get;  set; }
        
        public double HeightCm { get; set; }

        public double DepthCm { get; set; }

        public SerialNumber SerialNumber { get; }
        
        public Container(double heightCm, double tareWeightKg, double cargoWeightItself, double depthCm, double maxPayloadKg)
        {
            MassKg = cargoWeightItself + tareWeightKg;
            HeightCm = heightCm;
            TareWeightKg = tareWeightKg;
            CargoWeightItself = cargoWeightItself;
            DepthCm = depthCm;
            MaxPayloadKg = maxPayloadKg;
            SerialNumber = SerialNumberRegister.generateSerialNUmber();
            Console.WriteLine($"You have loaded -> Serial Number: {SerialNumber}");
        }
        // Emptying the cargo
        public void emptyCargo()
        {
            if (CargoWeightItself.Equals(0))
            {
                Console.WriteLine("Cargo is already empty");
            }
            else
            {
                MassKg = TareWeightKg;
                CargoWeightItself = 0;
            }
        }
        // if the mass of the cargo is greater than the capacity of a given container, we should throw an OverfillException error
        public void loadCargo(int massKg)
        {
            if (!CargoWeightItself.Equals(0))
            {
                Console.WriteLine("Cargo is not empty!");
                return;
            }
            if (massKg > MaxPayloadKg)
            {
                throw new OverfillException();
            }

            CargoWeightItself += massKg;
            MassKg += massKg;
        }

        public override string ToString()
        {
            return "> " + SerialNumber.getSerialNumber();
        }
    }

}