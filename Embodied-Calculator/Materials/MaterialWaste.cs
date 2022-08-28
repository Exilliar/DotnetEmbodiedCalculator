using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embodied_Calculator.Materials
{
    public class MaterialWaste
    {
        public double WasteRate;
        public double WasteFactor;

        public MaterialWaste(double wasteRate, double wasteFactor)
        {
            WasteRate = wasteRate;
            WasteFactor = wasteFactor;
        }
    }
}
