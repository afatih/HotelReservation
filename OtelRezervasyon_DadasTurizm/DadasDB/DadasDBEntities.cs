namespace OtelRezervasyon_DadasTurizm.DadasDB
{
    using OtelRezervasyon_DadasTurizm.DadasDB.Entities;
    using OtelRezervasyon_DadasTurizm.DadasDB.EntityMappings;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DadasDBEntities : DbContext
    {
     
        public DadasDBEntities()
            : base("server=DESKTOP-GOE244N\\SQLEXPRESS02; database=DadasOtelDB;Trusted_Connection=true;MultipleActiveResultSets=True")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DadasDBEntities, OtelRezervasyon_DadasTurizm.Migrations.Configuration>());
        }
        public virtual DbSet<BookDetail> BookDetails { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<RoomDetail> RoomDetails { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
            .Property(f => f.RoomNumber)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            modelBuilder.Configurations.Add(new BookDetailMapping());
            modelBuilder.Configurations.Add(new BookMapping());
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new GuestMapping());
            modelBuilder.Configurations.Add(new RoomDetailMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new RoomMapping());

            base.OnModelCreating(modelBuilder);


        }

    }

}