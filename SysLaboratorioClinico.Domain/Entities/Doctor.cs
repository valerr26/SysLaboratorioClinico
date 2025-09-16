using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLaboratorioClinico.Domain.Entities
{
    [Table("t_Doctor")]
    public class Doctor
    {
        [Key]
        [Column("iddoctor")]
        public int Id { get; set; }

        [Column("nombre")]
        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Column("apellido")]
        [Required, StringLength(50)]
        public string Apellido { get; set; }

        [Column("especialidad")]
        [Required, StringLength(100)]
        public string Especialidad { get; set; }

        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }

        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Column("licenciamedica")]
        [Required, StringLength(50)]
        public string LicenciaMedica { get; set; }

        [Column("idusuario")]
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }
    }
}
