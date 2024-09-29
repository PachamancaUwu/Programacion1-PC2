using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pc2.Models
{
    [Table("t_cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {   get; set;}
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? TipoCuenta { get; set; }
        public string? SaldoInicial{ get; set; }
    }
}