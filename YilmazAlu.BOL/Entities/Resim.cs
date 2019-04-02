using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YilmazAlu.BOL.Entities
{
    [Table("Resim")]
    public class Resim
    {
        public int ID { get; set; }
        [StringLength(50),Column(TypeName ="varchar")]
        public string ResimYol { get; set; }
        public int ReferansID { get; set; }
        public Referans Referans { get; set; }
        
    }
}