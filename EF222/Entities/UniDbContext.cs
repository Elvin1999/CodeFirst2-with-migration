namespace EF222.Entities
{
    using EF222.Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UniDbContext : DbContext
    {
        // Your context has been configured to use a 'UniDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EF222.Entities.UniDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'UniDbContext' 
        // connection string in the application configuration file.
        public UniDbContext()
            : base("name=UniDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UniDbContext, Configuration>());
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }
}