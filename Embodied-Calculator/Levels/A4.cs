using Embodied_Calculator.Materials;
using Embodied_Calculator.transport;

namespace Embodied_Calculator.Levels
{
    public class A4
    {
        private double _total;
        public double Total
        {
            get { return _total; }
        }

        public double Calculate(double volume, Material material, Transport[] transports)
        {
            var transTotal = transports.Aggregate(0, (double acc, Transport t) => acc * t.TEF);
            var mass = material.Density * volume;
            var carbon = (mass * transTotal) / 1000;
            _total = carbon;

            return _total;
        }
    }
}
