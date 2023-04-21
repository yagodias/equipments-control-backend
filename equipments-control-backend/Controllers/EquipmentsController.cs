using equipmentes_control.Persistence.Configs;
using equipments_control.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace equipments_control_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        private readonly EquipmentContext equipmentContext;

        public EquipmentsController(EquipmentContext equipmentContext)
        {
            this.equipmentContext = equipmentContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var equipment = await equipmentContext.Set<Equipment>().Include(a => a.Brand).Include(a => a.Department).SingleAsync(i => i.Id == id);

            return Ok(equipment);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Equipment equipment)
        {
            await equipmentContext.Set<Equipment>().AddAsync(equipment);
            await equipmentContext.SaveChangesAsync();

            return Ok();
        }
    }
}
