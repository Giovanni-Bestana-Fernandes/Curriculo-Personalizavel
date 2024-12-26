using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Curriculo_Personalizavel.Models;

[Table("Usuario")]
public class Usuario
{
    [Key]
    public string IdUsuario { get; set; }
    [ForeignKey("IdUsuario")]
    public IdentityUser ContaUsuario  { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
}