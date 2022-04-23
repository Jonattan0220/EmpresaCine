using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpresaCine.Models
{
    public partial class Ciudade
    {
        public Ciudade()
        {
            Multicines = new HashSet<Multicine>();
        }

        public int IdCiudad { get; set; }

        public string Nombre { get; set; } = null!;

        public string Estado { get; set; } = null!;

        public virtual ICollection<Multicine> Multicines { get; set; }
    }
}
