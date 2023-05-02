using AutoMapper;
using Microsoft.EntityFrameworkCore;
using waypoint_generator.Models.ScanPlan;

public interface IScanPlanService
{
    Dictionary<string, object> GetAll();
    BaseScanPlan GetById(int id);
    Dictionary<string, object> GetAllByMissionId(int missionId);
    BaseScanPlan Create(ScanPlanCreateRequest model);
    BaseScanPlan Update(int id, ScanPlanUpdateRequest model);
    void Delete(int id);
}

public class ScanPlanService : IScanPlanService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public ScanPlanService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Dictionary<string, object> GetAll()
    {
        var single_point = _context.ScanPlans.OfType<SinglePointPlan>().ToList();
        var principal = _context.ScanPlans.OfType<PrincipalPlan>().ToList();
        var raster = _context.ScanPlans.OfType<RasterPlan>().ToList();

        var plan_dict = new Dictionary<string, object>
        {
            { "SinglePointScans", single_point },
            { "PrincipalScans", principal },
            { "RasterScans", raster }
        };

        return plan_dict;
    }

    public BaseScanPlan GetById(int id)
    {
        var scanPlan = _context.ScanPlans.Find(id);
        if (scanPlan == null) throw new KeyNotFoundException("Scan plan not found");
        return scanPlan;
    }
    public Dictionary<string, object> GetAllByMissionId(int missionId)
    {
        var single_point = _context.ScanPlans.Where(Plan => Plan.MissionID == missionId).OfType<SinglePointPlan>().ToList();
        var principal = _context.ScanPlans.Where(Plan => Plan.MissionID == missionId).OfType<PrincipalPlan>().ToList();
        var raster = _context.ScanPlans.Where(Plan => Plan.MissionID == missionId).OfType<RasterPlan>().ToList();

        var plan_dict = new Dictionary<string, object>
        {
            { "SinglePointPlans", single_point },
            { "PrincipalPlans", principal },
            { "RasterPlans", raster }
        };
 
        return plan_dict;
    }
    public BaseScanPlan Create(ScanPlanCreateRequest model)
    {
        BaseScanPlan baseplan;

        switch (model.Type)
        {
            case 0:
                baseplan = _mapper.Map<SinglePointPlan>(model);
                _context.ScanPlans.Add(baseplan);
                _context.SaveChanges();
                return baseplan;
            case 1:
                baseplan = _mapper.Map<PrincipalPlan>(model);
                _context.ScanPlans.Add(baseplan);
                _context.SaveChanges();
                return baseplan;
            case 2:
                baseplan = _mapper.Map<RasterPlan>(model);
                _context.ScanPlans.Add(baseplan);
                _context.SaveChanges();
                return baseplan;

            default:
                throw new KeyNotFoundException();
        }

        
    }

    public BaseScanPlan Update(int id, ScanPlanUpdateRequest model)
    {
        var scanPlan = GetById(id);

        _mapper.Map(model, scanPlan);
        _context.Entry(scanPlan).State = EntityState.Modified;
        _context.SaveChanges();

        return scanPlan;
    }

    public void Delete(int id)
    {
        var scanPlan = GetById(id);
        _context.ScanPlans.Remove(scanPlan);
        _context.SaveChanges();
    }
}