using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Curriculo_Personalizavel.Models;

[Table("Curriculo")]
public class Curriculo
{
    [Key]
    public long IdCurriculo { get; set; }

    [Required]
    public int IdUsuario { get; set; }
    [ForeignKey("IdUsuario")]
    public Usuario Usuario { get; set; }

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }

    [Required]
    public int IdLingua { get; set; }
    [ForeignKey("IdLingua")]
    public Lingua Lingua { get; set; }

    public string CorTematicaDark { get; set; }

    public string CorTematicaWhite { get; set; }
}