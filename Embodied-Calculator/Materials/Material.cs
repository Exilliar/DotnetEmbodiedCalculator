namespace Embodied_Calculator.Materials
{
    public class Material
    {
        public string Name;
        public string Type;
        public double A13ECF;
        public string Source;
        public int Density;
        public MaterialWaste MaterialWaste;

        public Material(string name, string type, double a13ECF, string source, int density, MaterialWaste materialWaste)
        {
            Name = name;
            Type = type;
            A13ECF = a13ECF;
            Source = source;
            Density = density;
            MaterialWaste = materialWaste;
        }
    }
}
