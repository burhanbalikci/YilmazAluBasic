using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilmazAlu.BOL.Entities
{
    [Table("Admin")]
    public class Admin
    {
        public int ID { get; set; }
        [StringLength(20),Column(TypeName ="varchar")]
        public string KullaniciAdi { get; set; }
        [StringLength(50), Column(TypeName = "varchar")]
        public string Sifre { get; set; }
        [StringLength(50), Column(TypeName = "varchar")]
        public string IsimSoyisim { get; set; }
        [StringLength(50), Column(TypeName = "varchar"),NotMapped]
        public string Sifre2 { get; set; }
        
        [StringLength(20), Column(TypeName = "varchar")]
        public string Role { get; set; }
    }
}
