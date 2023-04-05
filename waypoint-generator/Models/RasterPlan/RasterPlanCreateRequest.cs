using System.ComponentModel.DataAnnotations;

namespace waypoint_generator.Models.RasterPlan
{
	public class RasterPlanCreateRequest
	{
		[Required]
		public string? Name { get; set; }

		[Required]
		public string? Comment { get; set; }

		[Required]
		public double AzimuthStart { get; set; }
		[Required]
		public double AzimuthStep { get; set; }
		[Required]
		public double AzimuthStop { get; set; }
		[Required]
		public double ElevationStart { get; set; }
		[Required]
		public double ElevationStep { get; set; }
		[Required]
		public double ElevationStop { get; set; }

		[Required]
		public double Speed { get; set; }
		[Required]
		public double Radius { get; set; }

		public int Polarization { get; set; }


		public enum PolarizationEnum
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
}
