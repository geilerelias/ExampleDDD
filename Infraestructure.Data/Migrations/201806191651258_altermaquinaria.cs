namespace Infraestructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altermaquinaria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Componente", "maquinaria_Id", c => c.Int());
            CreateIndex("dbo.Componente", "maquinaria_Id");
            AddForeignKey("dbo.Componente", "maquinaria_Id", "dbo.Maquinaria", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Componente", "maquinaria_Id", "dbo.Maquinaria");
            DropIndex("dbo.Componente", new[] { "maquinaria_Id" });
            DropColumn("dbo.Componente", "maquinaria_Id");
        }
    }
}
