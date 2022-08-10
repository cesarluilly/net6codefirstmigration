using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace net6codefirstmigration.Entidad
{
    public class Genero
    {
        [Key]
        [Column("Pk")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int intPk { get; set; }

        [Required]
        [Column("Nombre", TypeName = "nvarchar(100)")]
        public String strNombre { get; set; }

    }
}
