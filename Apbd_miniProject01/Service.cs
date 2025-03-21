using System.Collections.Generic;

namespace Apbd_miniProject01
{
    public static class Service
    {
        private static Dictionary<int, Container> accessibleContainers = new Dictionary<int, Container>();
        private static int counter = 0;
        static List<Ship> ships = new List<Ship>();

        public static Dictionary<int, Container> getAccessibleContainers()
        {
            return accessibleContainers;
        }

        public static int getCounter()
        {
            return counter;
        }

        public static List<Ship> getShips()
        {
            return ships;
        }

        public static void addShip(Ship ship)
        {
            ships.Add(ship);
        }

    }
}