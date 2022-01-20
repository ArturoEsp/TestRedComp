using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEB_API.Models
{
    public partial class Promedio
    {
        public int AlumnoId { get; set; }
        public decimal? Promedio1 { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
