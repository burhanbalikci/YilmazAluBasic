using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilmazAlu.BOL.Entities
{
    [Table("FirmaProfil")]
    public class FirmaProfil
    {
        public int ID { get; set; }
        [StringLength(2000),Column(TypeName ="Text")]
        public string Aciklama { get; set; }
        [StringLength(150), Column(TypeName = "varchar")]
        public string Resim { get; set; }
        [StringLength(200), Column(TypeName = "varchar")]
        public string Vizyon { get; set; }
        [StringLength(500), Column(TypeName = "Text")]
        public string Misyon { get; set; }
    }
}
