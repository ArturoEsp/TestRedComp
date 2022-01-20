using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Profesor> Get()
        {
            using (Models.DB_ESCUELAContext db = new Models.DB_ESCUELAContext())
            {
                var lst = (from a in db.Profesor
                           join b in db.Aula on a.AulaId equals b.Id
                           select new Profesor
                           {
                               Id = a.Id,
                               Nombre = a.Nombre,
                               Apellido = a.Apellido,
                               Identificacion = a.Identificacion,
                               Aula = b,
                               AulaId = b.Id
                           }).ToList();
                return Ok(lst);
            }
        }
    }
}
