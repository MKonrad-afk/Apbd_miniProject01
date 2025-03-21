namespace Apbd_miniProject01
{
    
    
    public class Refrigerated_Container : Container
    {
        public ProductType ProductTy;
        public int CargoTemperature;

        public Refrigerated_Container(double heightCm, double tareWeightKg, double cargoWeightItself, double depthCm, double maxPayloadKg, ProductType productType) : base(heightCm, tareWeightKg, cargoWeightItself, depthCm, maxPayloadKg)
        {
            ProductTy = productType;
            CargoTemperature = productType.LowestTemperature;
        }
        
        public override string ToString()
        {
            return base.ToString() +$", Product Type: {ProductTy}, LowestTemperature {CargoTemperature} - Liquid Container"; 
        }
    }

}