namespace TreePrunServices.Core.Commom.ObjectValues
{
    public class GeoCoordinate
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        /// <summary>
        /// Creates a representative for geocoordinates.
        /// </summary>
        /// <param name="latitude">should be[-90, 90]</param>
        /// <param name="longitude">should be[-180, 180]</param>
        /// <exception cref="ArgumentException"></exception>
        public GeoCoordinate(double latitude, double longitude)
        {
            if (latitude < -90 || latitude > 90)
                throw new ArgumentException("Latitude should be [-90, 90]");

            if (longitude < -180 || longitude > 180)
                throw new ArgumentException("Longitude should be[-180, 180]");
        }

    }
}
