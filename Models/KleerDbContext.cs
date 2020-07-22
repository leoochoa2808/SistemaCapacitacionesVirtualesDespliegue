using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class KleerDbContext : DbContext
    {
        public KleerDbContext(DbContextOptions<KleerDbContext> o) : base(o){}
        public DbSet<Evento> Eventos {get;set;}
        public DbSet<Categoria> Categorias {get;set;}
        public DbSet<Instructor> Instructores {get;set;}
        public DbSet<Participante> Participantes {get;set;}
        public DbSet<Participante_Evento> Participante_Eventos {get;set;}
        public DbSet<Gestor> Gestores {get; set;}
        public DbSet<Gestor_Evento> Gestor_Eventos {get; set;}
    }
}