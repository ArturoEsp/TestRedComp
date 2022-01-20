using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API.Models.Request
{
    public class CalificacionRequest
    {
        public int AlumnoId { get; set; }
        public int MateriaId { get; set; }
        public decimal Calificacion { get; set; }
    }
}
