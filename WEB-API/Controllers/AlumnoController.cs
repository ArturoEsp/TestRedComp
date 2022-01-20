using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_API.Models;
using Microsoft.Extensions.Logging;

namespace WEB_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Alumno> Get()
        {
            using (Models.DB_ESCUELAContext db = new Models.DB_ESCUELAContext())
            {
                var lst = (from a in db.Alumno
                           join b in db.Aula on a.AulaId equals b.Id
                           select new Alumno
                           {
                               Id = a.Id,
                               Nombre = a.Nombre,
                               Apellido = a.Apellido,
                               Cedula = a.Cedula,
                               Aula = b,
                               AulaId = b.Id
                           }).ToList();
                return Ok(lst);
            }
        }
        
    }
}
