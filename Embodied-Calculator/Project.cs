using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embodied_Calculator
{
    public enum Region
    {
        UK
    }
    public class Project
    {
        public string Name { get; set; }
        public Region Region { get; set; }
        public int Cost;
        public int FloorArea;
        public string SpeckleUrl { get; set; }
        public SpeckleObject[] speckleObjects { get; set; }

        public EmbodiedResult Calculate()
        {
            double A13Total = 0;
            double A4Total = 0;
            double A5Total = 0;
            foreach(var speckleObject in speckleObjects)
            {
                speckleObject.Calculate();
                A13Total += speckleObject.A13.Total;
                A4Total += speckleObject.A4.Total;
                A5Total += speckleObject.A5.Total;
            }
            var Total = A13Total + A4Total + A5Total;

            return new(Total, A13Total, A4Total, A5Total);
        }
    }
}
