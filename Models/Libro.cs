using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MisLibrosNet.Models;

class Libro
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string? Titulo { get; set; }

    [Required]
    public int Edicion { get; set; }

    [Required]
    public int EditorialId { get; set; }

    // Propiedad para manejo interno de EFCore
    // generalmente usadas para traer datos
    // de una relación entre tablas
    [NotMapped]
    public Editorial? Editorial { get; set; }

    [NotMapped]
    public List<AutorLibro>? AutoresLibros { get; set; }
}