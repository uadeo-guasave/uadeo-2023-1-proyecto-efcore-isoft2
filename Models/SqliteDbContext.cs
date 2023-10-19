using Microsoft.EntityFrameworkCore;

namespace MisLibrosNet.Models;

class SqliteDbContext : DbContext
{
    // agregar las tablas como DbSet
    public DbSet<Autor>? Autores { get; set; }
    public DbSet<Editorial>? Editoriales { get; set; }
    public DbSet<Libro>? Libros { get; set; }
    public DbSet<AutorLibro>? AutoresLibros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Db/biblioteca.db");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // (l => { func body })
        modelBuilder.Entity<Libro>(libro =>
        {
            libro.HasOne(l => l.Editorial)
                 .WithMany(e => e.Libros)
                 .HasForeignKey(l => l.EditorialId);
        });

        modelBuilder.Entity<AutorLibro>(autorLibro =>
        {
            autorLibro.HasKey(al => new { al.AutorId, al.LibroId });

            autorLibro.HasOne(al => al.Autor)
                      .WithMany(a => a.AutoresLibros)
                      .HasForeignKey(al => al.AutorId);

            autorLibro.HasOne(al => al.Libro)
                      .WithMany(l => l.AutoresLibros)
                      .HasForeignKey(al => al.LibroId);
        });

        base.OnModelCreating(modelBuilder);
    }
}