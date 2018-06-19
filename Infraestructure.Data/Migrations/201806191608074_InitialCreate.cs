namespace Infraestructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Componente",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CuentaBancaria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Numero = c.String(),
                        Saldo = c.Double(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovimientoFinanciero",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ValorRetiro = c.Double(nullable: false),
                        ValorConsignacion = c.Double(nullable: false),
                        FechaMovimiento = c.DateTime(nullable: false),
                        CuentaBancaria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CuentaBancaria", t => t.CuentaBancaria_Id)
                .Index(t => t.CuentaBancaria_Id);
            
            CreateTable(
                "dbo.Incidencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Maquinaria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placa = c.String(nullable: false, maxLength: 50),
                        Marca = c.String(nullable: false, maxLength: 50),
                        Linea = c.String(nullable: false, maxLength: 50),
                        Modelo = c.String(nullable: false, maxLength: 50),
                        Color = c.String(nullable: false, maxLength: 50),
                        FechaAdquisicion = c.String(nullable: false, maxLength: 50),
                        Chasi = c.String(nullable: false, maxLength: 50),
                        Motor = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 100),
                        State = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Country", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Tarea",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "CountryId", "dbo.Country");
            DropForeignKey("dbo.MovimientoFinanciero", "CuentaBancaria_Id", "dbo.CuentaBancaria");
            DropIndex("dbo.Person", new[] { "CountryId" });
            DropIndex("dbo.MovimientoFinanciero", new[] { "CuentaBancaria_Id" });
            DropTable("dbo.Tarea");
            DropTable("dbo.Person");
            DropTable("dbo.Maquinaria");
            DropTable("dbo.Incidencia");
            DropTable("dbo.MovimientoFinanciero");
            DropTable("dbo.CuentaBancaria");
            DropTable("dbo.Country");
            DropTable("dbo.Componente");
        }
    }
}
