using System;
using System.Collections.Generic;

namespace EmpresaCine.Models
{
    public partial class PeliculasMulticine
    {
        public int IdPeliculasMulticine { get; set; }
        public int IdPelicula { get; set; }
        public int IdMulticine { get; set; }
        public TimeSpan Horario { get; set; }

        public virtual Multicine IdMulticineNavigation { get; set; } = null!;
        public virtual Pelicula IdPeliculaNavigation { get; set; } = null!;
    }
}
