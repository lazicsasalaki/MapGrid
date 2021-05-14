namespace TileGrid
{
    public class GridSet
    {
        /// <summary>
        /// Create tile gridset
        /// </summary>
        /// <param name="srs">Spatial reference system</param>
        /// <param name="schema">Y axis schema,default TMS,y increase from down to top</param>
        /// <param name="minZoom">Min zoom,default 4</param>
        /// <param name="maxZoom">Max zoom,default 18</param>
        /// <param name="dpi">DPI,default 90.714</param>
        /// <param name="tileWidthPixel">Tile width(px),default 256 px</param>
        /// <param name="tielHeightPixel">Tile height(px),default 256 px</param>
        /// <returns>GridSet</returns>
        public static GridSet Create(SRS srs, YAxisSchema schema = YAxisSchema.Tms, int minZoom = 4, int maxZoom = 18, double dpi = 90.71428571428572, int tileWidthPixel = 256, int tielHeightPixel = 256)
        {
            return GridSetFactory.CreateGridSet(srs, schema, minZoom, maxZoom, dpi, tileWidthPixel, tielHeightPixel);
        }
        public int EPSG { get; set; }
        public double DPI { get; set; }
        public double TileWidthPixel { get; set; }
        public double TileHeightPixel { get; set; }
        public YAxisSchema YAxisSchema { get; set; }
        public int MinZoom { get; set; }
        public int MaxZoom { get; set; }
        public Grid[] GridLevels { get; set; }
        public int LevelCount => MaxZoom - MinZoom + 1;
        public double[] BoundingBox { get; set; }
        public GridSet() { }

        public GridSet(int ePSG, double dPI, double tileWidthPixel, double tileHeightPixel, YAxisSchema yAxisSchema, int minZoom, int maxZoom, Grid[] gridLevels)
        {
            EPSG = ePSG;
            DPI = dPI;
            TileWidthPixel = tileWidthPixel;
            TileHeightPixel = tileHeightPixel;
            YAxisSchema = yAxisSchema;
            MinZoom = minZoom;
            MaxZoom = maxZoom;
            GridLevels = gridLevels;
        }
    }
}
