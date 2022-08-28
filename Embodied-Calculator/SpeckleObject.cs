using Embodied_Calculator.Levels;
using Embodied_Calculator.Materials;
using Embodied_Calculator.transport;

namespace Embodied_Calculator
{
    public class SpeckleObject
    {
        private double _total { get; set; }
        public double Total
        {
            get { return _total; }
        }
        public A13 A13 { get; set; } = new A13();
        public A4 A4 { get; set; } = new A4();
        public A5 A5 { get; set; } = new A5();

        public double Volume { get; set; }
        public Material Material { get; set; }
        public Transport[] Transports { get; set; }
        public int Cost { get; set; }
        public string speckleId { get; set; }

        public double Calculate()
        {
            if (Volume == 0 || Material == null | Transports == null || Cost == 0)
            {
                throw new Exception("Volume, Material, Transports and Cost must be initialised");
            }
            A13.Calculate(Volume, Material);
            A4.Calculate(Volume, Material, Transports);
            A5.Calculate(Volume, Material, Cost, Transports);

            var res = A13.Total + A4.Total + A5.Total;
            _total = res;
            return res;
        }
        public double Calculate(double volume)
        {
            Volume = volume;
            return Calculate();
        }
        public double Calculate(double volume, Material material)
        {
            Volume = volume;
            Material = material;
            return Calculate();
        }
        public double Calculate(Material material)
        {
            Material = material;
            return Calculate();
        }
    }
}
