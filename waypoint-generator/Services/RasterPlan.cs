//using asset_management.Controllers;
//using AutoMapper;
//using System.Reflection;
//using waypoint_generator.Models.RasterPlan;
//using waypoint_generator.Models.ScanPlan;

//public interface IRasterPlanService
//{
//    IEnumerable<RasterPlan> GetAll();
//    RasterPlan GetById(RasterPlan id);
//    RasterPlan Create(RasterPlanCreateRequest model);
//    RasterPlan Update(int id, RasterPlanUpdateRequest model);
//    void Delete(int id);
//}

//public class RasterService : IRasterPlanService
//{

//    private DataContext _context;
//    private readonly IMapper _mapper;
//    public RasterService(DataContext context, IMapper mapper)
//    {
//        _context = context;
//        _mapper = mapper;
//    }

//    public IEnumerable<RasterPlan> GetAll()
//    {
//        return _context.RasterPlans;
//    }

//    public RasterPlan GetById(RasterPlan raster)
//    {
//        return raster;
//    }
//    public RasterPlan Create(RasterPlanCreateRequest model)
//    {
//        var raster = _mapper.Map<RasterPlan>(model);
//        _context.Add(raster);
//        _context.SaveChanges();

//        return raster;
//    }

//    public RasterPlan Update(int id, RasterPlanUpdateRequest model)
//    {
//        var raster = getRaster(id);

//        _mapper.Map(model, raster);
//        _context.RasterPlans.Update(raster);
//        _context.SaveChanges();

//        return raster;
//    }

//    public void Delete(int id)
//    {
//        var mission = getRaster(id);
//        _context.RasterPlans.Remove(mission);
//        _context.SaveChanges();
//    }

//    // Helper Function
//    private RasterPlan getRaster(int id)
//    {
//        var raster = _context.RasterPlans.Find(id);
//        if (raster == null) throw new KeyNotFoundException("Mission not found");
//        return raster;
//    }
//}