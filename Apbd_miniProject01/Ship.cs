using System;
using System.Collections.Generic;
using System.Linq;
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
        Dictionary<int, Container> containers = new Dictionary<int, Container>();
        Dictionary<int, Container> accessibleContainers = new Dictionary<int, Container>();
        private int counter0 = 0;
        private int counter1 = 0;
        public double MaxSpeed { get; set; }
        public int MaxContainersCapacity { get; private set; }
        public decimal MaxWeight { get; private set; }

        public Ship(double maxSpeed, int maxContainersCapacity, decimal maxWeight)
        {
            MaxSpeed = maxSpeed;
            MaxContainersCapacity = maxContainersCapacity;
            MaxWeight = maxWeight;
        }

        public void addContainer()
        {
            if (MaxContainersCapacity < containers.Count)
            {
                if (accessibleContainers.Count() == 0)
                {
                    Console.WriteLine("No accessible containers!\n Load cargo into container first");
                }
                else
                {
                    Console.WriteLine("Info: you can see bellow the list of available containers" +
                                      "\nType its number to load a container onto a ship" +
                                      "\nTo load list of containers type their numbers spaceseparated in format <1 2 3 4>");
                    showAccessibleContainers();
                    int choice = int.Parse(Console.ReadLine());
                    if (accessibleContainers.ContainsKey(choice)){
                    containers.Add(counter1++, accessibleContainers[choice]);
                    }
                    else
                    {
                        Console.WriteLine("Error: no accessible container found");
                    }
                }


            }
            else
            {
                Console.WriteLine("You cannot add more containers.");
            }
            
        }
        
        public void loadCargoINtoContainer(ContainerType containerType)
        {
                Console.WriteLine("To Load container give me following:" +
                                  "\n Height of the container in cm:");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("Depth of the container in cm:");
                double depth = double.Parse(Console.ReadLine());
                Console.WriteLine("Tare Weight of the container in kg:");
                double tareWeight = double.Parse(Console.ReadLine());
                Console.WriteLine("Weight of the cargo itself in kg:");
                double cargoWeight = double.Parse(Console.ReadLine());
                Console.WriteLine("Max payload of the container in kg:");
                double maxPayload = double.Parse(Console.ReadLine());

                switch (containerType)
                {
                    case ContainerType.R:
                        Console.WriteLine("Provide me with product type:\n" +
                                          "Name: (e.g Bananas)");
                        String nameOfProduct = Console.ReadLine();
                        Console.WriteLine("Lowest temperature of this product Type");
                        int lowestTemperature = int.Parse(Console.ReadLine());
                        ProductType productType = new ProductType(nameOfProduct, lowestTemperature);
                        accessibleContainers.Add(counter0 + 1,new Refrigerated_Container(height, tareWeight, cargoWeight, depth, maxPayload,
                            productType));
                        break;
                    case ContainerType.G:
                        Console.WriteLine("Pressure in atmosphere:");
                        double pressure = double.Parse(Console.ReadLine());
                        accessibleContainers.Add(counter0 + 1, new Gas_Containers(height, tareWeight, cargoWeight, depth, maxPayload,
                            pressure));
                        break;

                    case ContainerType.L:
                        Console.WriteLine("Product type of the container (choose between 0: hazardous, 1: ordinary):");
                        CargoType cargoType = (CargoType)int.Parse(Console.ReadLine());
                        accessibleContainers.Add(counter0 + 1, new Liquid_Conteiners(height, tareWeight, cargoWeight, depth, maxPayload,
                            cargoType));
                        break;
                }

        }

        public void showAccessibleContainers()
        {
            foreach (var container in accessibleContainers)
            {
                Console.WriteLine(container.Key + ": " + container.Value);
            }
        }

        public void showContainers()
        {
            foreach (var container in containers)
            {
                Console.WriteLine(container.Key + ": " + container.Value);
            }
        }

    }
    
}