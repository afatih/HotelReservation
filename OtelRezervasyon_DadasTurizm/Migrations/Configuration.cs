namespace OtelRezervasyon_DadasTurizm.Migrations
{
    using OtelRezervasyon_DadasTurizm.DadasDB;
    using OtelRezervasyon_DadasTurizm.DadasDB.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DadasDB.DadasDBEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }        

        protected override void Seed(DadasDB.DadasDBEntities context)
        {
            context.Users.AddOrUpdate(x => x.UserID, new User { UserName = "asd", UserPassword = "asd" });
            context.Users.AddOrUpdate(x => x.UserID, new User { UserName = "ömer", UserPassword = "ömer123" });
            context.Users.AddOrUpdate(x => x.UserID, new User { UserName = "hilal", UserPassword = "hilal123" });


            context.RoomDetails.AddOrUpdate(x => x.RoomTypeID, new RoomDetail { RoomTypeDetails = "Standart", RoomCapacity = 2, RoomDescription = "2 kişilik Standart oda", RoomPrice = 125 });
            context.RoomDetails.AddOrUpdate(x => x.RoomTypeID, new RoomDetail { RoomTypeDetails = "Deluxe", RoomCapacity = 2, RoomDescription = "2 kişilik Deluxe oda", RoomPrice = 250 });
            context.RoomDetails.AddOrUpdate(x => x.RoomTypeID, new RoomDetail { RoomTypeDetails = "FamilySuit", RoomCapacity = 4, RoomDescription = "4 kişilik Family Suit", RoomPrice = 400 });
            context.RoomDetails.AddOrUpdate(x => x.RoomTypeID, new RoomDetail { RoomTypeDetails = "KingSuit", RoomCapacity = 4, RoomDescription = "4 kişilik King Suit", RoomPrice = 800 });

            context.SaveChanges();

            RoomDetail Standart = context.RoomDetails.FirstOrDefault(r => r.RoomTypeDetails == "Standart");
            RoomDetail Deluxe = context.RoomDetails.FirstOrDefault(r => r.RoomTypeDetails == "Deluxe");
            RoomDetail FamilySuit = context.RoomDetails.FirstOrDefault(r => r.RoomTypeDetails == "FamilySuit");
            RoomDetail KingSuit = context.RoomDetails.FirstOrDefault(r => r.RoomTypeDetails == "KingSuit");

            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = Standart.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = Standart.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = Standart.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = Standart.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = Deluxe.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = Deluxe.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = FamilySuit.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = FamilySuit.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = FamilySuit.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = FamilySuit.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = FamilySuit.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = FamilySuit.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = KingSuit.RoomTypeID });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber, new Room {  RoomTypeID = KingSuit.RoomTypeID });
            context.Rooms.AddOrUpdate(x => x.RoomNumber, new Room { RoomTypeID = KingSuit.RoomTypeID });

        }
    }
}
