using NUnit.Framework;

namespace TileGrid.Test
{
    public class Tests
    {
        [Test]
        public void Test3857_256()
        {
            var gs = GridSet.Create(SRS.Epsg3857);

            Assert.AreEqual(3857,gs.EPSG);
            Assert.AreEqual(90.71428571428572,gs.DPI,1.0e-5);
            Assert.AreEqual(256,gs.TileWidthPixel);
            Assert.AreEqual(256,gs.TileHeightPixel);
            Assert.AreEqual(YAxisSchema.Tms,gs.YAxisSchema);
            Assert.AreEqual(4,gs.MinZoom);
            Assert.AreEqual(18,gs.MaxZoom);
            
            Assert.AreEqual(9783.939619140625,gs.GridLevels[0].Resolution,1.0e-5);
            Assert.AreEqual(4891.9698095703125,gs.GridLevels[1].Resolution,1.0e-5);
            Assert.AreEqual(2445.9849047851562,gs.GridLevels[2].Resolution,1.0e-5);
            Assert.AreEqual(1222.9924523925781,gs.GridLevels[3].Resolution,1.0e-5);
            Assert.AreEqual(611.4962261962891,gs.GridLevels[4].Resolution,1.0e-5);
            Assert.AreEqual(305.74811309814453,gs.GridLevels[5].Resolution,1.0e-5);
            Assert.AreEqual(152.87405654907226,gs.GridLevels[6].Resolution,1.0e-5);

            Assert.AreEqual(34942641.49693081,gs.GridLevels[0].ScaleDenom,1.0e-5);
            Assert.AreEqual(17471320.748465404,gs.GridLevels[1].ScaleDenom,1.0e-5);
            Assert.AreEqual(8735660.374232702,gs.GridLevels[2].ScaleDenom,1.0e-5);
            Assert.AreEqual(4367830.187116351,gs.GridLevels[3].ScaleDenom,1.0e-5);
            Assert.AreEqual(2183915.0935581755,gs.GridLevels[4].ScaleDenom,1.0e-5);
            Assert.AreEqual(1091957.5467790877,gs.GridLevels[5].ScaleDenom,1.0e-5);
            Assert.AreEqual(545978.7733895439,gs.GridLevels[6].ScaleDenom,1.0e-5);
        }
    }
}