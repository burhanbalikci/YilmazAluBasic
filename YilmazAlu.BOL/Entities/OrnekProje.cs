using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YilmazAlu.BOL.Entities
{
    [Table("OrnekProje")]
    public class OrnekProje
    {
        public int ID { get; set; }
        [StringLength(150), Column(TypeName = "varchar")]
        public string Resim { get; set; }
        [StringLength(50),Column(TypeName ="varchar")]
        public string Aciklama { get; set; }
    }
}