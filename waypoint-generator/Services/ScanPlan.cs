using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using waypoint_generator.Models.ScanPlan;

public interface IScanPlanService
{
    IEnumerable<BaseScanPlan> GetAll();
    BaseScanPlan GetById(int id);
    BaseScanPlan Create(BaseScanPlan model);
    BaseScanPlan Update(int id, BaseScanPlan model);
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

    public IEnumerable<BaseScanPlan> GetAll()
    {
        return _context.ScanPlans;
    }

    public BaseScanPlan GetById(int id)
    {
        var scanPlan = _context.ScanPlans.Find(id);
        if (scanPlan == null) throw new KeyNotFoundException("Scan plan not found");
        return scanPlan;
    }

    public BaseScanPlan Create(BaseScanPlan model)
    {
        _context.ScanPlans.Add(model);
        _context.SaveChanges();
        return model;
    }

    public BaseScanPlan Update(int id, BaseScanPlan model)
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