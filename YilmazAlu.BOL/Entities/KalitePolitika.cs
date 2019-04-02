using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilmazAlu.BOL.Entities
{
    [Table("KalitePolitika")]
    public class KalitePolitika
    {
        public int ID { get; set; }
        [StringLength(5000),Column(TypeName = "Text")]
        public string Aciklama { get; set; }
    }
}
