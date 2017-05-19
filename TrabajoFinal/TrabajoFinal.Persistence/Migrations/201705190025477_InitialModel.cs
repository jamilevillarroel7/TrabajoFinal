namespace TrabajoFinal.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autores",
                c => new
                    {
                        Autorid = c.Int(nullable: false, identity: true),
                        Nacionalidad_Nacionalidadid = c.Int(),
                    })
                .PrimaryKey(t => t.Autorid)
                .ForeignKey("dbo.Nacionalidades", t => t.Nacionalidad_Nacionalidadid)
                .Index(t => t.Nacionalidad_Nacionalidadid);
            
            CreateTable(
                "dbo.Nacionalidades",
                c => new
                    {
                        Nacionalidadid = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Nacionalidadid);
            
            CreateTable(
                "dbo.Carritos",
                c => new
                    {
                        Carritoid = c.Int(nullable: false, identity: true),
                        Cliente_Clienteid = c.Int(),
                    })
                .PrimaryKey(t => t.Carritoid)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Clienteid)
                .Index(t => t.Cliente_Clienteid);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Clienteid = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Clienteid);
            
            CreateTable(
                "dbo.Libros",
                c => new
                    {
                        Libroid = c.Int(nullable: false, identity: true),
                        TipoLibro = c.Int(nullable: false),
                        Categoria = c.Int(nullable: false),
                        Autor_Autorid = c.Int(),
                        Carrito_Carritoid = c.Int(),
                        Venta_Ventaid = c.Int(),
                    })
                .PrimaryKey(t => t.Libroid)
                .ForeignKey("dbo.Autores", t => t.Autor_Autorid)
                .ForeignKey("dbo.Carritos", t => t.Carrito_Carritoid)
                .ForeignKey("dbo.Ventas", t => t.Venta_Ventaid)
                .Index(t => t.Autor_Autorid)
                .Index(t => t.Carrito_Carritoid)
                .Index(t => t.Venta_Ventaid);
            
            CreateTable(
                "dbo.Comprobantes",
                c => new
                    {
                        Comprobanteid = c.Int(nullable: false, identity: true),
                        Cliente_Clienteid = c.Int(),
                        Venta_Ventaid = c.Int(),
                    })
                .PrimaryKey(t => t.Comprobanteid)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Clienteid)
                .ForeignKey("dbo.Ventas", t => t.Venta_Ventaid)
                .Index(t => t.Cliente_Clienteid)
                .Index(t => t.Venta_Ventaid);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        Ventaid = c.Int(nullable: false, identity: true),
                        Envio = c.Int(nullable: false),
                        Cliente_Clienteid = c.Int(),
                        Pago_Pagoid = c.Int(),
                    })
                .PrimaryKey(t => t.Ventaid)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Clienteid)
                .ForeignKey("dbo.Pagos", t => t.Pago_Pagoid)
                .Index(t => t.Cliente_Clienteid)
                .Index(t => t.Pago_Pagoid);
            
            CreateTable(
                "dbo.Pagos",
                c => new
                    {
                        Pagoid = c.Int(nullable: false, identity: true),
                        TipoPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pagoid);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        Empleadoid = c.Int(nullable: false, identity: true),
                        TipoEmpleado = c.Int(nullable: false),
                        Libreria_Libreriaid = c.Int(),
                    })
                .PrimaryKey(t => t.Empleadoid)
                .ForeignKey("dbo.Librerias", t => t.Libreria_Libreriaid)
                .Index(t => t.Libreria_Libreriaid);
            
            CreateTable(
                "dbo.Librerias",
                c => new
                    {
                        Libreriaid = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Libreriaid);
            
            CreateTable(
                "dbo.LocalLibrerias",
                c => new
                    {
                        Localid = c.Int(nullable: false, identity: true),
                        Empleado_Empleadoid = c.Int(),
                        Libreria_Libreriaid = c.Int(),
                    })
                .PrimaryKey(t => t.Localid)
                .ForeignKey("dbo.Empleados", t => t.Empleado_Empleadoid)
                .ForeignKey("dbo.Librerias", t => t.Libreria_Libreriaid)
                .Index(t => t.Empleado_Empleadoid)
                .Index(t => t.Libreria_Libreriaid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LocalLibrerias", "Libreria_Libreriaid", "dbo.Librerias");
            DropForeignKey("dbo.LocalLibrerias", "Empleado_Empleadoid", "dbo.Empleados");
            DropForeignKey("dbo.Empleados", "Libreria_Libreriaid", "dbo.Librerias");
            DropForeignKey("dbo.Comprobantes", "Venta_Ventaid", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "Pago_Pagoid", "dbo.Pagos");
            DropForeignKey("dbo.Libros", "Venta_Ventaid", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "Cliente_Clienteid", "dbo.Clientes");
            DropForeignKey("dbo.Comprobantes", "Cliente_Clienteid", "dbo.Clientes");
            DropForeignKey("dbo.Libros", "Carrito_Carritoid", "dbo.Carritos");
            DropForeignKey("dbo.Libros", "Autor_Autorid", "dbo.Autores");
            DropForeignKey("dbo.Carritos", "Cliente_Clienteid", "dbo.Clientes");
            DropForeignKey("dbo.Autores", "Nacionalidad_Nacionalidadid", "dbo.Nacionalidades");
            DropIndex("dbo.LocalLibrerias", new[] { "Libreria_Libreriaid" });
            DropIndex("dbo.LocalLibrerias", new[] { "Empleado_Empleadoid" });
            DropIndex("dbo.Empleados", new[] { "Libreria_Libreriaid" });
            DropIndex("dbo.Ventas", new[] { "Pago_Pagoid" });
            DropIndex("dbo.Ventas", new[] { "Cliente_Clienteid" });
            DropIndex("dbo.Comprobantes", new[] { "Venta_Ventaid" });
            DropIndex("dbo.Comprobantes", new[] { "Cliente_Clienteid" });
            DropIndex("dbo.Libros", new[] { "Venta_Ventaid" });
            DropIndex("dbo.Libros", new[] { "Carrito_Carritoid" });
            DropIndex("dbo.Libros", new[] { "Autor_Autorid" });
            DropIndex("dbo.Carritos", new[] { "Cliente_Clienteid" });
            DropIndex("dbo.Autores", new[] { "Nacionalidad_Nacionalidadid" });
            DropTable("dbo.LocalLibrerias");
            DropTable("dbo.Librerias");
            DropTable("dbo.Empleados");
            DropTable("dbo.Pagos");
            DropTable("dbo.Ventas");
            DropTable("dbo.Comprobantes");
            DropTable("dbo.Libros");
            DropTable("dbo.Clientes");
            DropTable("dbo.Carritos");
            DropTable("dbo.Nacionalidades");
            DropTable("dbo.Autores");
        }
    }
}
