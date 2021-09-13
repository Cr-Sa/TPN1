using Microsoft.EntityFrameworkCore;
using TPN1.Domain.Entities;
using System;

namespace TPN1.AccessData
{
    public class CineContext : DbContext
    {
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Funciones> Funciones { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Tickets> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4KK02DC\SQLEXPRESS01;Database=TPN1;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Peliculas>(entity =>
            {
                entity.ToTable("Peliculas");
                entity.HasKey(pel => pel.PeliculaId);
                entity.Property(pel => pel.Titulo).HasMaxLength(50).IsRequired();
                entity.Property(pel => pel.Poster).HasMaxLength(255).IsRequired();
                entity.Property(pel => pel.Sinopsis).HasMaxLength(255).IsRequired();
                entity.Property(pel => pel.Trailer).HasMaxLength(255).IsRequired();


            });
           
            modelBuilder.Entity<Funciones>(entity =>
            {
                entity.ToTable("Funciones");
                entity.HasKey(fun => fun.FuncionId);
                entity.Property(fun => fun.PeliculaId).HasMaxLength(50).IsRequired();
                entity.Property(fun => fun.SalaId).HasMaxLength(50).IsRequired();
                entity.Property(fun => fun.Fecha).IsRequired();
                entity.Property(fun => fun.Horario).IsRequired();

                entity.HasOne(pel => pel.PeliculasNavigator).WithMany(fun => fun.FuncionesNavigator);
                entity.HasOne(sal => sal.SalasNavigator).WithMany(fun => fun.FuncionesNavigator);
            });
            
            modelBuilder.Entity<Salas>(entity =>
            {
                entity.ToTable("Salas");
                entity.HasKey(sal => sal.SalaId);
                entity.Property(sal => sal.Capacidad).HasMaxLength(35).IsRequired();

            });
         
            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.ToTable("Tickets");
               
                entity.HasKey(compuesta => new { compuesta.TicketId, compuesta.FuncionId });
                entity.Property(tik => tik.Usuario).HasMaxLength(50).IsRequired();
                entity.Property(tik => tik.FuncionId).IsRequired();

                entity.HasOne(fun => fun.FuncionesNavigator).WithMany(tik => tik.TicketsNavigator);


            });
            
            modelBuilder.Entity<Peliculas>().HasData(
                new Peliculas { PeliculaId = 1, Titulo = "Star Wars: episodio IV - una nueva esperanza", Poster = "https://es.web.img3.acsta.net/c_310_420/medias/nmedia/18/71/18/12/20061511.jpg", Sinopsis = "Sinopsis 1", Trailer = "Trailer 1" },
                new Peliculas { PeliculaId = 2, Titulo = "El imperio contraataca", Poster = "Poster 2", Sinopsis = "Sinopsis 2", Trailer = "Trailer 2" },
                new Peliculas { PeliculaId = 3, Titulo = "Star Wars: episodio VI - el retorno del Jedi", Poster = "Poster 3", Sinopsis = "Sinopsis 3", Trailer = "Trailer 3" },
                new Peliculas { PeliculaId = 4, Titulo = "Star Wars: episodio I - la amenaza fantasma", Poster = "Poster 4", Sinopsis = "Sinopsis 4", Trailer = "Trailer 4" },
                new Peliculas { PeliculaId = 5, Titulo = "Star Wars: episodio II - el ataque de los clones", Poster = "Poster 5", Sinopsis = "Sinopsis 5", Trailer = "Trailer 5" },
                new Peliculas { PeliculaId = 6, Titulo = "Star wars: episodio III - la venganza de los sith", Poster = "Poster 1", Sinopsis = "Sinopsis 1", Trailer = "Trailer 1" },
                new Peliculas { PeliculaId = 7, Titulo = "Star Wars: el despertar de la fuerza", Poster = "Poster 2", Sinopsis = "Sinopsis 2", Trailer = "Trailer 2" },
                new Peliculas { PeliculaId = 8, Titulo = "Star Wars: Episodio VIII", Poster = "Poster 3", Sinopsis = "Sinopsis 3", Trailer = "Trailer 3" },
                new Peliculas { PeliculaId = 9, Titulo = "Star Wars: Episodio IX", Poster = "Poster 4", Sinopsis = "Sinopsis 4", Trailer = "Trailer 4" },
                new Peliculas { PeliculaId = 10, Titulo = "Rogue One: una historia de Star Wars", Poster = "Poster 5", Sinopsis = "Sinopsis 5", Trailer = "Trailer 5" }
                );
                    

            modelBuilder.Entity<Salas>().HasData(
               new Salas { SalaId = 1, Capacidad = 5 },
               new Salas { SalaId = 2, Capacidad = 15 },
               new Salas { SalaId = 3, Capacidad = 35 }              
               );
                    
        }
    }
}