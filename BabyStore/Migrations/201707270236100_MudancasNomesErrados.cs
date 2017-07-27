namespace BabyStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudancasNomesErrados : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ProductImageMappings", new[] { "ProductImageId" });
            CreateIndex("dbo.ProductImageMappings", "ProductImageID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ProductImageMappings", new[] { "ProductImageID" });
            CreateIndex("dbo.ProductImageMappings", "ProductImageId");
        }
    }
}
