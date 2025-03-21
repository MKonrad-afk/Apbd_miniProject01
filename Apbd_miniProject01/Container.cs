using System;
using Microsoft.Ajax.Utilities;

namespace Apbd_miniProject01
{
    public class Container
    {
        //sum of the weight
        public int MassKg { get; private set; }
        //cargo weight
        public int CargoWeightItself { get; private set; }
        //container weight
        public int TareWeightKg { get; private set; }
        //how much we can load
        public int MaxPayloadKg { get; private set; }
        
        public int HeightCm { get; private set; }

        public int DepthCm { get; private set; }

        public SerialNumber SerialNumber { get; }
        
        public Container(int massKg, int heightCm, int tareWeightKg, int cargoWeightItself, int depthCm, int maxPayloadKg)
        {
            MassKg = massKg;
            HeightCm = heightCm;
            TareWeightKg = tareWeightKg;
            CargoWeightItself = cargoWeightItself;
            DepthCm = depthCm;
            MaxPayloadKg = maxPayloadKg;
            SerialNumber = SerialNumberRegister.generateSerialNUmber();
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
            if (CargoWeightItself + massKg > MaxPayloadKg)
            {
                throw new OverfillException();
            }

            CargoWeightItself += massKg;
            MassKg += massKg;
        }
    }

    public class OverfillException : Exception
    {
        public OverfillException()
        : base("OverfillException")
        {
        }
    }
}