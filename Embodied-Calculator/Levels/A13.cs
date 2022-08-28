using Embodied_Calculator.Materials;

namespace Embodied_Calculator.Levels
{
    public class A13
    {
        private double _total;

        public double Total
        {
            get { return _total; }
        }

        public double Calculate(double volume, Material material)
        {
            var mass = volume * material.Density;
            _total = mass * material.A13ECF;
            return _total;
        }
    }
}
