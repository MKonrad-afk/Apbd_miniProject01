namespace Apbd_miniProject01
{
    public class ProductType
    {
        public string name{set;get;}
        public int lowestTemperature{set;get;}

        public ProductType(string name, int lowestTemperature)
        {
            this.name = name;
            this.lowestTemperature = lowestTemperature;
        }
    }
}