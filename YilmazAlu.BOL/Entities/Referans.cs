using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilmazAlu.BOL.Entities
{
    [Table("Referans")]
    public class Referans
    {
        public int ID { get; set; }
        [StringLength(30),Column(TypeName ="varchar")]
        public string ProjeAd { get; set; }
        [StringLength(50), Column(TypeName = "varchar")]
        public string ProjeAdres { get; set; }
        [StringLength(200), Column(TypeName = "varchar")]
        public string Aciklama { get; set; }
        public ICollection<Resim> Resim { get; set; }

    }
}
