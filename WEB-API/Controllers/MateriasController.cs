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
    public class MateriasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Materium> Get()
        {
            using (Models.DB_ESCUELAContext db = new Models.DB_ESCUELAContext())
            {
                var lst = (from a in db.Materia
                           join b in db.Profesor on a.ProfesorId equals b.Id
                           select new Materium
                           {
                               Nombre = a.Nombre,
                               Profesor = b,
                               ProfesorId = b.Id,
                               Id = a.Id
                           }).ToList();
                return Ok(lst);
            }
        }
    }
}
