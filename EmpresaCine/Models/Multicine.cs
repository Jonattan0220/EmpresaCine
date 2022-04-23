using System;
using System.Collections.Generic;

namespace EmpresaCine.Models
{
    public partial class Multicine
    {
        public Multicine()
        {
            PeliculasMulticines = new HashSet<PeliculasMulticine>();
        }

        public int IdMulticine { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdCiudad { get; set; }

        public virtual Ciudade IdCiudadNavigation { get; set; } = null!;
        public virtual ICollection<PeliculasMulticine> PeliculasMulticines { get; set; }
    }
}
