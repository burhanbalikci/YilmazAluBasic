using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YilmazAlu.BOL.Entities
{
    [Table("Hizmet")]
    public class Hizmet
    {
        public int ID { get; set; }
        [StringLength(5000),Column(TypeName = "Text")]
        public string AluDograma { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string OfisAraBol { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string CehpheSistem { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string SurguCamKapi { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string FotoselliKapi { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string KisBahce { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string PanjurKepenk { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string KupesteKorkuluk { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string KatlanirCam { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string CamCephe { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string KompozitPanel { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string PVCDograma { get; set; }
        [StringLength(5000), Column(TypeName = "Text")]
        public string CamBalkon { get; set; }
    }
}
