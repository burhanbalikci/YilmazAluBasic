using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilmazAlu.BOL.Entities
{
    [Table("UygulamaAlan")]
    public class UygulamaAlan
    {
        public int ID { get; set; }
        [StringLength(30),Column(TypeName ="varchar")]
        public string Aciklama { get; set; }
    }
}
