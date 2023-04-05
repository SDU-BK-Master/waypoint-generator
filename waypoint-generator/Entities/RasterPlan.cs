public class RasterPlan : BaseScanPlan
{
    public double AzimuthStart { get; set; }
    public double AzimuthStep { get; set; }
    public double AzimuthStop { get; set; }

    public double ElevationStart { get; set; }
    public double ElevationStep { get; set; }
    public double ElevationStop { get; set; }

    public double Speed { get; set; }
    public double Radius { get; set; }

    public enum Polarization
    {
        Co,
        Cross
    }

    public enum Direction
    {
        Increasing,
        Decreasing,
        Alternating
    }
    public enum Plane
    {
        Azimuth,
        Elevation,
        Diagonal
    }


}