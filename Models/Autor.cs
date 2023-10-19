using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MisLibrosNet.Models;

class Autor
{
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string? Nombres { get; set; }
    
    [Required, MaxLength(50)]
    public string? Apellidos { get; set; }

    [NotMapped]
    public List<AutorLibro>? AutoresLibros { get; set; }
}
