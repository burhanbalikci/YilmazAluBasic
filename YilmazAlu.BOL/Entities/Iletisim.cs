using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilmazAlu.BOL.Entities
{
    [Table("Iletisim")]
    public class Iletisim
    {
        public int ID { get; set; }
        [StringLength(150),Column(TypeName ="varchar")]
        public string Adres { get; set; }
        [StringLength(150), Column(TypeName = "varchar")]
        public string Telefon { get; set; }
        [StringLength(150), Column(TypeName = "varchar")]
        public string Fax { get; set; }
        [StringLength(150), Column(TypeName = "varchar")]
        public string Mail { get; set; }
    }
}
