using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLaboratorioClinico.Domain.Entities
{
    [Table("t_Usuario")]
    public class Usuario
    {
        [Key]
        [Column("idusuario")]
        public int Id { get; set; }

        [Column("nombre")]
        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Column("contraseña")]
        [Required, StringLength(50)]
        public string Contraseña { get; set; }

        [Column("idrol")]
        [ForeignKey("Rol")]
        public int IdRol { get; set; }
        public Rol Rol { get; set; }
    }
}
