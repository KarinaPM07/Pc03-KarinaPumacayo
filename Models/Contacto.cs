using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pc03_KarinaPumacayo.Models
{
    [Table("venta")]
    public class Contacto{

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        
        [Column("nombre")]
        public string nombre { get; set; }

        
        [Column("foto")]
        public string foto { get; set; }

        [Column("descripcion")]
        public string descripcion { get; set; }

        [Column("precio")]
        public int precio { get; set; }

        [EmailAddress]
        [Column("celular")]
        public int celular { get; set; }
     

        [Column("lugar")]
        public string lugar { get; set; }

        [Column("comprador")]
        public string comprador { get; set; }
        
        [Column("categoria")]
        public string categoria { get; set; }

        [Column("mensaje")]
        public string Mensaje { get; set; }
    }

}