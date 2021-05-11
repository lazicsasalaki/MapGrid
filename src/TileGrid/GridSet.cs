namespace TileGrid
{
    public class GridSet
    {
        public int EPSG { get; set; }
        public double DPI { get; set; }
        public double TileWidthPixel { get; set; }
        public double TileHeightPixel { get; set; }
        public YAxisSchema YAxisSchema { get; set; }
        public int MinZoom { get; set; }
        public int MaxZoom { get; set; }
        public int LevelCount => GridLevels.Length;
        public Grid[] GridLevels { get; set; }
    }
}
