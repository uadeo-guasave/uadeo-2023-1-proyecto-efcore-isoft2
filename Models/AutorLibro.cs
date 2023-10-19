using System.ComponentModel.DataAnnotations.Schema;

namespace MisLibrosNet.Models;

class AutorLibro
{
    public int AutorId { get; set; }
    public int LibroId { get; set; }

    // Propiedas para manejo interno de EFCore
    // generalmente usadas para traer datos
    // de una relación entre tablas
    [NotMapped]
    public Autor? Autor { get; set; }

    [NotMapped]
    public Libro? Libro { get; set; }
}