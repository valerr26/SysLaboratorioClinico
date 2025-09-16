using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLaboratorioClinico.Domain.Entities
{
    [Table("t_Rol")]
    public class Rol
    {
        [Key]
        [Column("idrol")]
        public int Id { get; set; }

        [Column("nombre")]
        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Column("descripcion")]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
