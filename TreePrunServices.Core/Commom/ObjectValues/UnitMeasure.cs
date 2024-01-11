namespace TreePrunServices.Core.Commom.ObjectValues
{
    public class UnitMeasure(double unitInMeters)
    {
        private readonly double _meters = unitInMeters;

        public static readonly UnitMeasure Empty = new(-1);

        public double GetInMeters() 
        { 
            return _meters;
        }

        public double GetInCentimeters()
        {
            return _meters/100;
        }

        public double GetInMilimeters()
        {
            return _meters/1000;
        }
    }
}
