
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Types")]
    public class Types
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public uint Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, informe o Nome")]
        [StringLength(30,ErrorMessage ="O Nome deve possuir no máximo 30 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Cor de Exibição")]
        [Required(ErrorMessage = "Por favor, informe a Cor")]
        [StringLength(7,ErrorMessage ="O Nome deve possuir no máximo 7 caracteres")]
        public string Color { get; set; } = string.Empty;
    }
}