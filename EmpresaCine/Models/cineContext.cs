using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmpresaCine.Models
{
    public partial class cineContext : DbContext
    {
        public cineContext()
        {
        }

        public cineContext(DbContextOptions<cineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ciudade> Ciudades { get; set; } = null!;
        public virtual DbSet<Genero> Generos { get; set; } = null!;
        public virtual DbSet<Multicine> Multicines { get; set; } = null!;
        public virtual DbSet<Pelicula> Peliculas { get; set; } = null!;
        public virtual DbSet<PeliculasMulticine> PeliculasMulticines { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudade>(entity =>
            {
                entity.HasKey(e => e.IdCiudad)
                    .HasName("ciudades_pkey");

                entity.ToTable("ciudades");

                entity.Property(e => e.IdCiudad).HasColumnName("id_ciudad");

                entity.Property(e => e.Estado)
                    .HasColumnType("character varying")
                    .HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .HasColumnType("character varying")
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero)
                    .HasName("generos_pkey");

                entity.ToTable("generos");

                entity.Property(e => e.IdGenero).HasColumnName("id_genero");

                entity.Property(e => e.Estado)
                    .HasColumnType("character varying")
                    .HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .HasColumnType("character varying")
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Multicine>(entity =>
            {
                entity.HasKey(e => e.IdMulticine)
                    .HasName("multicines_pkey");

                entity.ToTable("multicines");

                entity.Property(e => e.IdMulticine).HasColumnName("id_multicine");

                entity.Property(e => e.IdCiudad).HasColumnName("id_ciudad");

                entity.Property(e => e.Nombre)
                    .HasColumnType("character varying")
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Multicines)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("multicines_id_ciudad_fkey");
            });

            modelBuilder.Entity<Pelicula>(entity =>
            {
                entity.HasKey(e => e.IdPelicula)
                    .HasName("peliculas_pkey");

                entity.ToTable("peliculas");

                entity.Property(e => e.IdPelicula).HasColumnName("id_pelicula");

                entity.Property(e => e.Estado)
                    .HasColumnType("character varying")
                    .HasColumnName("estado");

                entity.Property(e => e.IdGenero).HasColumnName("id_genero");

                entity.Property(e => e.Poster)
                    .HasColumnType("character varying")
                    .HasColumnName("poster");

                entity.Property(e => e.Trailer)
                    .HasColumnType("character varying")
                    .HasColumnName("trailer");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Peliculas)
                    .HasForeignKey(d => d.IdGenero)
                    .HasConstraintName("peliculas_id_genero_fkey");
            });

            modelBuilder.Entity<PeliculasMulticine>(entity =>
            {
                entity.HasKey(e => e.IdPeliculasMulticine)
                    .HasName("peliculas_multicine_pkey");

                entity.ToTable("peliculas_multicine");

                entity.Property(e => e.IdPeliculasMulticine).HasColumnName("id_peliculas_multicine");

                entity.Property(e => e.Horario).HasColumnName("horario");

                entity.Property(e => e.IdMulticine).HasColumnName("id_multicine");

                entity.Property(e => e.IdPelicula).HasColumnName("id_pelicula");

                entity.HasOne(d => d.IdMulticineNavigation)
                    .WithMany(p => p.PeliculasMulticines)
                    .HasForeignKey(d => d.IdMulticine)
                    .HasConstraintName("peliculas_multicine_id_multicine_fkey");

                entity.HasOne(d => d.IdPeliculaNavigation)
                    .WithMany(p => p.PeliculasMulticines)
                    .HasForeignKey(d => d.IdPelicula)
                    .HasConstraintName("peliculas_multicine_id_pelicula_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
