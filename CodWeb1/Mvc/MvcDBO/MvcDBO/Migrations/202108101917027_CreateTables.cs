namespace MvcDBO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armazenamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoArmazenamento = c.String(),
                        Medidas = c.String(),
                        TipoBarramento = c.String(),
                        TamanhoArmazenamento = c.Int(nullable: false),
                        Marca = c.String(),
                        Modelo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fontes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QtW = c.Int(nullable: false),
                        Modulariade = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Gabinetes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TamanhosSuportadosPlacaMae = c.String(),
                        Tamanho = c.String(),
                        Medidas = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MemoriaRams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TamanhoMemoria = c.Int(nullable: false),
                        Frequencia = c.Int(nullable: false),
                        Barramento = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlacaDeVideos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FrequenciaBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FrequenciaMax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Litografia = c.Int(nullable: false),
                        Marca = c.String(),
                        Modelo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlacaMaes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoBarramentoMemoriaRam = c.String(),
                        QtBarramentoMemoriaRam = c.Int(nullable: false),
                        TipoBarramentoArmazenamento = c.String(),
                        QtBarramentoArmazenamento = c.Int(nullable: false),
                        Soquete = c.String(),
                        Chipset = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Processadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QtNucleos = c.Int(nullable: false),
                        QtThreads = c.Int(nullable: false),
                        FrequenciaBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FrequenciaMax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Litografia = c.Int(nullable: false),
                        Soquete = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Processadors");
            DropTable("dbo.PlacaMaes");
            DropTable("dbo.PlacaDeVideos");
            DropTable("dbo.MemoriaRams");
            DropTable("dbo.Gabinetes");
            DropTable("dbo.Fontes");
            DropTable("dbo.Armazenamentoes");
        }
    }
}
