namespace TileGrid
{
    public class SRS
    {
        public static SRS Epsg4326 => new SRS
                    (
                        4326,
                        Unit.Degree,
                        111319.49079327358,
                        new double[] { 73.62, 16.7, 134.77, 53.56 }
                    );
        public static SRS Epsg3857 => new SRS
                    (
                        3857,
                        Unit.Meter,
                        1,
                        new double[] {
                            -20037508.34,
                            -20037508.34,
                            20037508.34,
                            20037508.34}
                    );
        public SRS(int ePSG, Unit unit, double metersPerUnit, double[] bBox)
        {
            EPSG = ePSG;
            Unit = unit;
            MetersPerUnit = metersPerUnit;
            BBox = bBox;
        }

        public int EPSG { get; set; }
        public Unit Unit { get; set; }
        public double MetersPerUnit { get; set; }
        public double[] BBox { get; set; }// minx miny maxx maxy
    }
}
