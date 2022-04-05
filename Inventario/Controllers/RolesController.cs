using Inventario.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.Controllers
{
    [Route("api/roles")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public RolesController(ApplicationDbContext context)
        {
            this.context = context;
        }


        //GET: api/roles/todos
        [HttpGet("todos")]
        public async Task<ActionResult<List<Rol>>> Todos()
        {
            return await context.Roles.ToListAsync();
        }
    }
}
