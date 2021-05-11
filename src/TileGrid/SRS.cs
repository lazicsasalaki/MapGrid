namespace TileGrid
{
    public class SRS
    {
        public int EPSG { get; set; }
        public Unit Unit { get; set; }
        public double MetersPerUnit { get; set; }
        public double[] BBox { get; set; }// minx miny maxx maxy
    }
}
