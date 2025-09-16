using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLaboratorioClinico.Domain.Entities
{
    [Table("t_Examen")]
    public class Examen
    {
        [Key]
        [Column("idexamen")]
        public int Id { get; set; }

        [Column("nombre")]
        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [Column("fecha")]
        [Required]
        public DateTime Fecha { get; set; }

        [Column("idpaciente")]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }

        public Paciente Paciente { get; set; }
    }
}
