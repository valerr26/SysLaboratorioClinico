using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLaboratorioClinico.Domain.Entities
{
    [Table("t_Cita")]
    public class Cita
    {
        [Key]
        [Column("idcita")]
        public int Id { get; set; }

        [Column("fechahora")]
        [Required]
        public DateTime FechaHora { get; set; }

        [Column("motivo")]
        [StringLength(200)]
        public string Motivo { get; set; }

        [Column("estado")]
        [Required]
        public string Estado { get; set; }

        [Column("notasconsulta")]
        [StringLength(500)]
        public string NotasConsulta { get; set; }

        [Column("idpaciente")]
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }

        public Paciente Paciente { get; set; }

        [Column("iddoctor")]
        [ForeignKey("Doctor")]
        public int IdDoctor { get; set; }

        public Doctor Doctor { get; set; }
    }
}
