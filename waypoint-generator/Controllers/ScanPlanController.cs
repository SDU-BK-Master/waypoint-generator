using Microsoft.AspNetCore.Mvc;
using waypoint_generator.Models.ScanPlan;

namespace asset_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScanPlanController : ControllerBase
    {
        private IScanPlanService _scanPlanService;

        public ScanPlanController(IScanPlanService scanPlanService)
        {
            _scanPlanService = scanPlanService;

        }

        // GET: api/<AntennaController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_scanPlanService.GetAll()); ;
        }

        // GET api/<AntennaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_scanPlanService.GetById(id));
        }

        // POST api/<AntennaController>
        [HttpPost]
        public IActionResult Post([FromBody] BaseScanPlan model)
        {
            var drone = _scanPlanService.Create(model);

            return Ok(drone);
        }

        // PUT api/<AntennaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BaseScanPlan model)
        {
            var drone = _scanPlanService.Update(id, model);
            return Ok(drone);
        }

        // DELETE api/<AntennaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _scanPlanService.Delete(id);
            return Ok(new { message = $"Scan Plan {id} deleted" });
        }
    }
}