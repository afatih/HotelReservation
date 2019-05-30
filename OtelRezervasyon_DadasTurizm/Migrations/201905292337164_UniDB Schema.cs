namespace OtelRezervasyon_DadasTurizm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookDetails",
                c => new
                    {
                        BookDetailsID = c.Int(nullable: false, identity: true),
                        BookID = c.Int(),
                        RoomNumber = c.Int(),
                        RoomPayment = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BookDetailsID)
                .ForeignKey("dbo.Books", t => t.BookID)
                .ForeignKey("dbo.Rooms", t => t.RoomNumber)
                .Index(t => t.BookID)
                .Index(t => t.RoomNumber);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        CheckInDate = c.DateTime(),
                        CheckOutDate = c.DateTime(),
                        NightStay = c.Short(),
                        TotalCost = c.Decimal(precision: 18, scale: 2),
                        IsDeleted = c.Boolean(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PersonID = c.String(),
                        Phone = c.String(),
                        Eposta = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.String(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        GuestID = c.Int(nullable: false, identity: true),
                        BookDetailsID = c.Int(nullable: false),
                        GuestFirstName = c.String(),
                        GuestLastName = c.String(),
                        GuestPersonelID = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDelete = c.Boolean(),
                    })
                .PrimaryKey(t => t.GuestID)
                .ForeignKey("dbo.BookDetails", t => t.BookDetailsID, cascadeDelete: true)
                .Index(t => t.BookDetailsID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomNumber = c.Int(nullable: false, identity: true),
                        RoomTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomNumber)
                .ForeignKey("dbo.RoomDetails", t => t.RoomTypeID, cascadeDelete: true)
                .Index(t => t.RoomTypeID);
            
            CreateTable(
                "dbo.RoomDetails",
                c => new
                    {
                        RoomTypeID = c.Int(nullable: false, identity: true),
                        RoomTypeDetails = c.String(),
                        RoomDescription = c.String(),
                        RoomCapacity = c.Byte(),
                        RoomPrice = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RoomTypeID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserPassword = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "RoomTypeID", "dbo.RoomDetails");
            DropForeignKey("dbo.BookDetails", "RoomNumber", "dbo.Rooms");
            DropForeignKey("dbo.Guests", "BookDetailsID", "dbo.BookDetails");
            DropForeignKey("dbo.Books", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.BookDetails", "BookID", "dbo.Books");
            DropIndex("dbo.Rooms", new[] { "RoomTypeID" });
            DropIndex("dbo.Guests", new[] { "BookDetailsID" });
            DropIndex("dbo.Books", new[] { "CustomerID" });
            DropIndex("dbo.BookDetails", new[] { "RoomNumber" });
            DropIndex("dbo.BookDetails", new[] { "BookID" });
            DropTable("dbo.Users");
            DropTable("dbo.RoomDetails");
            DropTable("dbo.Rooms");
            DropTable("dbo.Guests");
            DropTable("dbo.Customers");
            DropTable("dbo.Books");
            DropTable("dbo.BookDetails");
        }
    }
}
