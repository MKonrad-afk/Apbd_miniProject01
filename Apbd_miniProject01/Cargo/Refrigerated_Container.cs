namespace Apbd_miniProject01
{
    
    
    public class Refrigerated_Container : Container
    {
        public ProductType productType;
        public int CargoTemperature;

        public Refrigerated_Container(double heightCm, double tareWeightKg, double cargoWeightItself, double depthCm, double maxPayloadKg, ProductType productType) : base(heightCm, tareWeightKg, cargoWeightItself, depthCm, maxPayloadKg)
        {
            this.productType = productType;
            CargoTemperature = productType.lowestTemperature;
        }
        
        
    }
}