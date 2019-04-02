using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilmazAlu.BOL.Entities
{
    [Table("IsOrtak")]
    public class IsOrtak
    {
        public int ID { get; set; }
        [StringLength(50),Column(TypeName ="varchar")]
        public string Logo { get; set; }
        [StringLength(50), Column(TypeName = "varchar")]
        public string SirketIsmi { get; set; }
    }
}
