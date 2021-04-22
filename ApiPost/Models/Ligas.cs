using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPost.Models
{
    [Table("Ligas")]
    public class Ligas
    {
        [Key]
        public int IdLiga { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
    }
}
