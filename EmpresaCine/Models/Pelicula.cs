using System;
using System.Collections.Generic;

namespace EmpresaCine.Models
{
    public partial class Pelicula
    {
        public Pelicula()
        {
            PeliculasMulticines = new HashSet<PeliculasMulticine>();
        }

        public int IdPelicula { get; set; }
        public int IdGenero { get; set; }
        public string Poster { get; set; } = null!;
        public string Trailer { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual Genero IdGeneroNavigation { get; set; } = null!;
        public virtual ICollection<PeliculasMulticine> PeliculasMulticines { get; set; }
    }
}
