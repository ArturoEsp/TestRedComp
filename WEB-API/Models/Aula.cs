using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEB_API.Models
{
    public partial class Aula
    {
        public Aula()
        {
            Alumno = new HashSet<Alumno>();
            Profesor = new HashSet<Profesor>();
        }

        public int Id { get; set; }
        public string Numero { get; set; }
        public string Edificio { get; set; }

        public virtual ICollection<Alumno> Alumno { get; set; }
        public virtual ICollection<Profesor> Profesor { get; set; }
    }
}
