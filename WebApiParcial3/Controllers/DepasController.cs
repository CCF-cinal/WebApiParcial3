using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiParcial3.Entidades;

namespace WebApiParcial3.Controllers
{
    [ApiController]
    [Route("departamentos")]
    public class DepasController:ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public DepasController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Depa>>> Get()
        {
            return await dbContext.Departamentos.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult> Post(Depa depa)
        {
            dbContext.Add(depa);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Depa depa, int id)
        {
            if (depa.Id != id)
            {
                return BadRequest("El id del departamento no coincide con el establecido en la url.");
            }
            dbContext.Update(depa);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
