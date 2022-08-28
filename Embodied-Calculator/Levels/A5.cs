using Embodied_Calculator.Materials;
using Embodied_Calculator.transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embodied_Calculator.Levels
{
    public class A5
    {
        private double _total;
        public double Total
        {
            get { return _total; }
        }
        private double _waste;
        public double Waste
        {
            get { return _waste; }
        }
        private double _site;
        public double Site
        {
            get { return _site; }
        }

        public double Calculate(double volume, Material material, double cost, Transport[] transports)
        {
            // TODO: write method
            var waste = CalculateWaste(volume, material, transports);
            var site = CalculateSite(cost);
            var carbon = waste + site;
            _total = carbon;
            return carbon;
        }

        public double CalculateWaste(double volume, Material material, Transport[] transports)
        {
            var wasteVolume = volume * (1 / (1 - material.MaterialWaste.WasteRate) - 1);
            var a13 = new A13();
            var a4 = new A4();
            a13.Calculate(wasteVolume, material);
            a4.Calculate(wasteVolume, material, transports);
            var a13Total = a13.Total;
            var a4Total = a4.Total;

            var waste = a13Total + a4Total;
            _waste = waste;

            return waste;
        }
        public double CalculateSite(double cost)
        {
            var site = (cost * 1400) / 100000;
            _site = site;
            return site;
        }
    }
}
