namespace KafeKod.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UrunSiparisDetayCascadeDeleteOff : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SiparişDetaylar", "UrunId", "dbo.Ürünler");
            AddForeignKey("dbo.SiparişDetaylar", "UrunId", "dbo.Ürünler", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparişDetaylar", "UrunId", "dbo.Ürünler");
            AddForeignKey("dbo.SiparişDetaylar", "UrunId", "dbo.Ürünler", "Id", cascadeDelete: true);
        }
    }
}
