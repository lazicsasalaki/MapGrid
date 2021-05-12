# Map Tile Grid
Map tile grid helper lib.

# How to use
## GridSet can be seen every where
Create gridset  with 256 * 256 px,TMS schema,90.7142,epsg 3857.
```csharp
var gs = GridSet.Create(SRS.Epsg3857,YAxisSchema.Tms,1,20,90.7142,256,256);
```
Or simply call
```csharp
var gs = GridSet.Create(SRS.Epsg3857);
```

## Other Projecion
SRS infos can be check at [epsg.io](http://epsg.io/).
### China CGCS 2000
``` csharp
var gs = GridSet.Create(SRS.Epsg4490);
```
