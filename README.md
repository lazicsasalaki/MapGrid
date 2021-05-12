# Map Tile Grid
Map tile grid helper lib.

# How to use
## GridSet can be seen every where
Create gridset  with 256 * 256 px,TMS schema,90.7142,epsg 3857.
```csharp
var gs = GridSet.Create(SRS.Epsg4326,YAxisSchema.Tms,1,20,90.7142,256,256);
```
Or simply call
```csharp
var gs = GridSet.Create(SRS.Epsg4326);
```

## Other Projecion
SRS infos can be check at [epsg.io](http://epsg.io/).
```csharp
var srs = new SRS(4490,Unit.Degree,111319.49079327358,new double[]{73.62,16.7,134.77,53.56});
var gs = GridSet.Create(srs,YAxisSchema.Tms,1,20,90.7142,256,256);
```

## China CGCS 2000
``` csharp
var gs = GridSet.Create(SRS.Epsg4490);
```