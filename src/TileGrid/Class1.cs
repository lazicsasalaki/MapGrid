using System;

namespace TileGrid
{
    internal static  class GridSetFactory
    {
        GridSet CreateGridSet(SRS srs,YAxisSchema schema,int minZoom,int maxZoom,double dpi,int tileWidthPixel,int tielHeightPixel)
        {
            if(schema != YAxisSchema.Tms || schema != YAxisSchema.Xyz)
            {
                throw new NotSupportedException();
            }

            int tileNumberWide,tileNumberHigh;

            //maxx - minx   minx miny maxx maxy 0 1 2 3 
            var extentWidth = srs.BBox[2] - srs.BBox[0];
            var extentHeight = srs.BBox[3] - srs.BBox[1];

            var xRes = extentWidth / tileWidthPixel;
            var yRes = extentHeight / tielHeightPixel;

            if(xRes <= yRes)
            {
                tileNumberWide = 1;
                tileNumberHigh = (int)Math.Round(yRes / xRes);

                yRes = yRes / tileNumberHigh;
            }
            else
            {// N tile wide but one tile high
                tileNumberHigh = 1;
                tileNumberWide = (int)Math.Round(xRes / yRes);

                xRes = xRes / tileNumberWide; //xres == extent / (256 * N) ==  (extentX / 256) * ( 1  /  N) ==  xRes / N
            }

            var res = Math.Max(xRes,yRes);
            var exWidth = tileNumberWide * tileWidthPixel * res;
            var exHeight = tileNumberHigh * tielHeightPixel * res;

            var exBBox = new double[]{srs.BBox[0],srs.BBox[1],srs.BBox[2],srs.BBox[3]};
            //bbox minx miny maxx maxy
            exBBox[0] = exBBox[0] + exWidth;
            if(schema == YAxisSchema.Tms)//y from down to top
            {
                exBBox[3] = exBBox[1] + exHeight;
            }else if(schema == YAxisSchema.Xyz){//y from top to down
                exBBox[3] = exBBox[3] - exHeight;
            }


            var levelNumber = maxZoom - minZoom + 1;
            var resArr = new double[levelNumber];
            resArr[0] = res;
            for (int i = 1; i < levelNumber; i++) 
            {
                resArr[i] = res[i - 1] / 2.0;
            }

            var gs = new GridSet();

            gs.EPSG = srs.EPSG;
            gs.TileHeightPixel = tielHeightPixel;
            gs.TileWidthPixel = tileWidthPixel;
            gs.DPI = pixelSize;
            gs.YAxisSchema = schema;
            gs.MinZoom = minZoom;
            gs.MaxZoom = maxZoom;

            for (int i = 0; i < levelNumber; i++)
            {
                var grid = new Grid();
                grid.Resolution = resArr[i];
                grid.ScaleDenom = (resArr[i] * srs.MetersPerUnit) / (0.0254/dpi);

                grid.Resolution * tileWidthPixel
            }

            






        }
    }
}
