using asset_management.Controllers;
using AutoMapper;
using System.Reflection;
using waypoint_generator.Models.ScanPlan;

public interface IScanPlanService
{
    IEnumerable<BaseScanPlan> GetAll();
    BaseScanPlan GetById(BaseScanPlan id);
    BaseScanPlan Create(BaseScanPlan model);
    BaseScanPlan Update(int id, BaseScanPlan model);
    void Delete(int id);
}

public class ScanPlanService : IScanPlanService
{

    private DataContext _context;
    private readonly IMapper _mapper;
    public ScanPlanService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<BaseScanPlan> GetAll()
    {
        return _context.BaseScanPlan;
    }

    public BaseScanPlan GetById(BaseScanPlan baseScan)
    {
        return baseScan;
    }
    public BaseScanPlan Create(ScanPlanCreateRequest model)
    {
        var mission = _mapper.Map<BaseScanPlan>(model);
        _context.Add(mission);
        _context.SaveChanges();

        return mission;
    }

    public BaseScanPlan Update(int id, ScanPlanUpdateRequest model)
    {
        var mission = getMission(id);

        _mapper.Map(model, mission);
        _context.Missions.Update(mission);
        _context.SaveChanges();

        return mission;
    }

    public void Delete(int id)
    {
        var mission = getMission(id);
        _context.Missions.Remove(mission);
        _context.SaveChanges();
    }



    // Helper Function
    private BaseScanPlan getMission(int id)
    {
        var mission = _context.Missions.Find(id);
        if (mission == null) throw new KeyNotFoundException("Mission not found");
        return mission;
    }
}