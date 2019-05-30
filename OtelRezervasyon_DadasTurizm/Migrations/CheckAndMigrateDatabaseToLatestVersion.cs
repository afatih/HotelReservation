using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon_DadasTurizm.Migrations
{
    public class CheckAndMigrateDatabaseToLatestVersion<TContext, TMigrationsConfiguration> : DbMigrationsConfiguration<TContext>, IDatabaseInitializer<TContext>
    where TContext : DbContext
    where TMigrationsConfiguration : DbMigrationsConfiguration<TContext>, new()
    {
        public virtual void InitializeDatabase(TContext context)
        {
            var migratorBase = ((MigratorBase)new DbMigrator(Activator.CreateInstance<TMigrationsConfiguration>()));
            if (migratorBase.GetPendingMigrations().Any())
                migratorBase.Update();

            
        }








    }
}
