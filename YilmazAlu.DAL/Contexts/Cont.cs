using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YilmazAlu.BOL.Entities;

namespace YilmazAlu.DAL.Contexts
{
    public class Cont:DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<FirmaProfil> FirmaProfil { get; set; }
        public DbSet<Haber> Haber { get; set; }
        public DbSet<Hizmet> Hizmet { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<IsOrtak> IsOrtak { get; set; }
        public DbSet<KalitePolitika> KalitePolitika { get; set; }
        public DbSet<OrnekProje> OrnekProje { get; set; }
        public DbSet<Referans> Referans { get; set; }
        public DbSet<Resim> Resim { get; set; }
        public DbSet<UygulamaAlan> UygulamaAlan { get; set; }
    }
}
