using RoeldeWit.FootballManager.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RoeldeWit.FootballManager.SqlDataAccess.Classes
{
    /// <summary>
    /// DbContext for FootballManager
    /// </summary>
    public class FootballContext : DbContext
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public FootballContext()
            : base("FootballContext")
        {

        }

        /// <summary>
        /// DbSet for clubs
        /// </summary>
        public DbSet<Club> Clubs { get; set; }

        /// <summary>
        /// DbSet for countries
        /// </summary>
        public DbSet<Country> Countries { get; set; }

        /// <summary>
        /// DbSet for leagues
        /// </summary>
        public DbSet<League> Leagues { get; set; }

        /// <summary>
        /// Method that's called when the model is created
        /// </summary>
        /// <param name="modelBuilder">DbModelBuilder</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
