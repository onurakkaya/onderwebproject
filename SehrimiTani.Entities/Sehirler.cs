using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehrimiTani.Entities
{
    [Table("Sehirler")]
    public class Sehirler:MyEntitiyBase
    {
        [Required,StringLength(25)]  
        public string Sehiradi { get; set; }
        public virtual List<Yorumlar> Yorumlar { get; set; }
    }
}
