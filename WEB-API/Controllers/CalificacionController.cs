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
    public class CalificacionController : ControllerBase
    {

        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.CalificacionRequest model)
        {
            using (Models.DB_ESCUELAContext db = new Models.DB_ESCUELAContext())
            {
                Models.Calificacion oCalificacion = new Calificacion();
                oCalificacion.AlumnoId = model.AlumnoId;
                oCalificacion.MateriaId = model.MateriaId;
                oCalificacion.Calificacion1 = model.Calificacion;
                db.Calificacion.Add(oCalificacion);
                db.SaveChanges();
            }

            return Ok();
        }
    }
}
