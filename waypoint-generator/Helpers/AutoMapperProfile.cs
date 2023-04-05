using AutoMapper;
using Microsoft.AspNetCore.Components.Routing;
using System.Text;
using waypoint_generator.Models.CalibrationPlan;
using waypoint_generator.Models.RasterPlan;
using waypoint_generator.Models.ScanPlan;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ScanPlanCreateRequest, PrincipalPlan>();
        CreateMap<ScanPlanCreateRequest, RasterPlan>();
        CreateMap<ScanPlanCreateRequest, SinglePointPlan>();
        CreateMap<ScanPlanUpdateRequest, PrincipalPlan>();
        CreateMap<ScanPlanUpdateRequest, RasterPlan>();
        CreateMap<ScanPlanUpdateRequest, SinglePointPlan>();

        CreateMap<CalibrationPlanCreateRequest, BeamFindingPlan>();
        CreateMap<CalibrationPlanCreateRequest, RollAlignmentPlan>();
        CreateMap<CalibrationPlanUpdateRequest, BeamFindingPlan>();
        CreateMap<CalibrationPlanUpdateRequest, RollAlignmentPlan>();
    }
}