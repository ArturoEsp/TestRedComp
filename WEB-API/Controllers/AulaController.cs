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
    public class AulaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Aula> Get()
        {
            using (Models.DB_ESCUELAContext db = new Models.DB_ESCUELAContext())
            {
                var lst = (from a in db.Aula
                           select a).ToList();
                return Ok(lst);
            }
        }
    }
}
