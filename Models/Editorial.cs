using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MisLibrosNet.Models;

class Editorial
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string? Nombre { get; set; }

    [MaxLength(20)]
    public string? Telefono { get; set; }

    [MaxLength(200)]
    public string? Domicilio { get; set; }

    // Solo para manejo de EFCore
    [NotMapped]
    public List<Libro>? Libros { get; set; }
}