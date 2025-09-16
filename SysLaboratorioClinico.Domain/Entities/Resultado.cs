using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLaboratorioClinico.Domain.Entities
{
    [Table("t_Resultado")]
    public class Resultado
    {
        [Key]
        [Column("idresultado")]
        public int Id { get; set; }

        [Column("fecha")]
        [Required]
        public DateTime Fecha { get; set; }

        [Column("resultadoexmamen")]
        [Required, StringLength(500)]
        public string ResultadoExamen { get; set; }

        [Column("idexamen")]
        [ForeignKey("Examen")]
        public int IdExamen { get; set; }

        public Examen Examen { get; set; }

        [Column("iddoctor")]
        [ForeignKey("Doctor")]
        public int IdDoctor { get; set; }

        public Doctor Doctor { get; set; }
    }
}
