using System;
using System.Collections.Generic;
using Microsoft.Ajax.Utilities;

namespace Apbd_miniProject01
{
    public enum ContainerType
    {
        R,
        G,
        L
    }
    public class Ship
    {
        List<Container> containers = new List<Container>();
        public double MaxSpeed { get; set; }
        public int MaxContainersCapacity { get; private set; }
        public decimal MaxWeight { get; private set; }

        public Ship(double maxSpeed, int maxContainersCapacity, decimal maxWeight)
        {
            MaxSpeed = maxSpeed;
            MaxContainersCapacity = maxContainersCapacity;
            MaxWeight = maxWeight;
        }

        public void AddContainer(ContainerType containerType)
        {
            switch (containerType)
            {
                case ContainerType.R:
                    Console.WriteLine("To add a R container give me following:" +
                                      "\n Height of the container in cm:");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Depth of the container in cm:");
                    double depth = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Tare Weight of the container in kg:");
                    double tareWeight = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Weight of the cargo itself in kg:");
                    double cargoWeight = double.Parse(Console.ReadLine());
                    
                    break;
                case ContainerType.G:
                    break;
                case ContainerType.L:
                    break;
            }   
        }
        
    }
    
}