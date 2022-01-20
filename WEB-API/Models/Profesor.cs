using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEB_API.Models
{
    public partial class Profesor
    {
        public Profesor()
        {
            Materia = new HashSet<Materia>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public int AulaId { get; set; }

        public virtual Aula Aula { get; set; }
        public virtual ICollection<Materia> Materia { get; set; }
    }
}
