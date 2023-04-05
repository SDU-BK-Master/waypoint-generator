using AutoMapper;
using System.Text;
using waypoint_generator.Models.CalibrationPlan;
using waypoint_generator.Models.ScanPlan;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ScanPlanCreateRequest, BaseScanPlan>();
        CreateMap<ScanPlanUpdateRequest, BaseScanPlan>();

        CreateMap<CalibrationPlanCreateRequest, BaseCalibrationPlan>();
        CreateMap<CalibrationPlanUpdateRequest, BaseCalibrationPlan>();
    }
}