using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLaboratorioClinico.Domain.Entities
{
    [Table("t_Paciente")]
    public class Paciente
    {
        [Key]
        [Column("idpaciente")]
        public int Id { get; set; }

        [Column("nombre")]
        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Column("apellido")]
        [Required, StringLength(50)]
        public string Apellido { get; set; }

        [Column("fechanacimiento")]
        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }

        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }

        [Column("direccion")]
        [StringLength(100)]
        public string Direccion { get; set; }

        [Column("idusuario")]
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }
    }
}
