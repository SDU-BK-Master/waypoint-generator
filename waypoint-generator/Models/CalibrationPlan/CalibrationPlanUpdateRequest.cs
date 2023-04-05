using System.ComponentModel.DataAnnotations;

namespace waypoint_generator.Models.CalibrationPlan
{
    public class CalibrationPlanUpdateRequest
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Comment { get; set; }
    }
}
