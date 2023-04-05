using System.ComponentModel.DataAnnotations;

namespace waypoint_generator.Models.ScanPlan
{
	public class ScanPlanCreateRequest
	{
		[Required]
		public string? Name { get; set; }

		[Required]
		public string? Comment { get; set; }
	}
}
