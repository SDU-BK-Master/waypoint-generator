public class RollAlignment : BaseCalibrationPlan
{
    public int Duration { get; set; }
    public float OffsetAzimuth { get; set; }
    public float OffsetElevation { get; set; }
    public float Radius { get; set; }
    public bool Zenith { get; set; }

}