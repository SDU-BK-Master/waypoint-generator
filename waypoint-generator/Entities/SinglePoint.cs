public class SinglePoint : BaseScanPlan
{
    public double Duration { get; set; }
    public double OffsetAzimuth { get; set; }
    public double OffsetElevation { get; set; }
    public double Radius { get; set; }
    public enum Polarization
    {
        Co,
        Cross
    }

}