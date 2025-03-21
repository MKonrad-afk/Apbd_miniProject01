namespace Apbd_miniProject01
{
    public class Container
    {
        public int MassKg { get; private set; }
        public int HeightCm { get; private set; }
        public int TareWeightKg { get; private set; }
        public int CargoWeightItself { get; private set; }
        public int DepthCm { get; private set; }
        
        public Container(int massKg, int heightCm, int tareWeightKg, int cargoWeightItself, int depthCm)
        {
            MassKg = massKg;
            HeightCm = heightCm;
            TareWeightKg = tareWeightKg;
            CargoWeightItself = cargoWeightItself;
            DepthCm = depthCm;
        }
    }
}