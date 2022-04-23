using System;
using System.Collections.Generic;

namespace EmpresaCine.Models
{
    public partial class Genero
    {
        public Genero()
        {
            Peliculas = new HashSet<Pelicula>();
        }

        public int IdGenero { get; set; }
        public string Nombre { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
