using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKod.Data
{
    public class KafeContext:DbContext
    {
        public KafeContext():base("name=BaglantiCumlem")
        {
          
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Urun>().ToTable("Urunler");
            modelBuilder.Entity<Urun>()
                .HasMany(x => x.SiparisDetayslar)
                .WithRequired(x=>x.Urun)
                .HasForeignKey(x=>x.UrunId)
                .WillCascadeOnDelete(false);
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar { get; set; }
      
    }
}
