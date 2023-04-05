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

		[Required]
		public int Polarization { get; set; }

		[Required]
		public int Direction { get; set; }

		[Required]
		public int Plane { get; set; }

	}
}
