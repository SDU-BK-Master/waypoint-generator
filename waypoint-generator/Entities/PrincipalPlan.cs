public class PrincipalPlan : BaseScanPlan
{
	public double Start { get; set; }
	public double Step { get; set; }
	public double Stop { get; set; }

	public double Speed { get; set; }
	public double Radius { get; set; }
	public double Roll { get; set; }
	public enum Direction
	{
		Increasing,
		Decreasing
	}
	public enum Polarization
	{
		Co,
		Cross
	}
	public enum Plane
	{
		Azimuth,
		Elevation,
		Diagonal
	}




}