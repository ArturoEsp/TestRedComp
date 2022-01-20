using System;
using System.Collections.Generic;

#nullable disable

namespace WEB_API.Models
{
    public partial class Materium
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ProfesorId { get; set; }

        public virtual Profesor Profesor { get; set; }
    }
}
