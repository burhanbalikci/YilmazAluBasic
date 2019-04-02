using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilmazAlu.BOL.Entities
{
    [Table("Haber")]
    public class Haber
    {
        public int ID { get; set; }
        [StringLength(500),Column(TypeName ="Text")]
        public string Aciklama { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime AciklamaTarih { get; set; }
    }
}
