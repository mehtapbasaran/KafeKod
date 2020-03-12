namespace KafeKod.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UrunStokSutun : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ürünler", "StoktaYok", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ürünler", "StoktaYok");
        }
    }
}
