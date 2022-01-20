using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEB_API.Models
{
    public partial class Calificacion
    {
        public int AlumnoId { get; set; }
        public int MateriaId { get; set; }
        public decimal? Calificacion1 { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Materia Materia { get; set; }
    }
}
