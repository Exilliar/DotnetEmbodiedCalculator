namespace Embodied_Calculator.transport
{
    public class Transport
    {
        public double Distance;
        public double TEF;
        public string Name;

        public Transport(double TEF, string name)
        {
            this.TEF = TEF;
            Name = name;
        }
    }
}
