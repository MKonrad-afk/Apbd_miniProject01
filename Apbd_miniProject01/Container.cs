namespace Apbd_miniProject01
{
    public class Container
    {
        public int MassKg { get; private set; }
        public int HeightCm { get; private set; }
        public int TareWeightKg { get; private set; }
        public int CargoWeightItself { get; private set; }
        public int DepthCm { get; private set; }

        public SerialNumber SerialNumber = SerialNumberRegister.generateSerialNUmber();
        public int MaxPayloadKg { get; private set; }
        
        public Container(int massKg, int heightCm, int tareWeightKg, int cargoWeightItself, int depthCm, int maxPayloadKg)
        {
            MassKg = massKg;
            HeightCm = heightCm;
            TareWeightKg = tareWeightKg;
            CargoWeightItself = cargoWeightItself;
            DepthCm = depthCm;
            MaxPayloadKg = maxPayloadKg;
        }
        // Emptying the cargo
        public void emptyCargo()
        {
            
        }
        // if the mass of the cargo is greater than the capacity of a given container, we should throw an OverfillException error
        public void loadCargo(int massKg)
        {
            
        }
        
        
    }
}