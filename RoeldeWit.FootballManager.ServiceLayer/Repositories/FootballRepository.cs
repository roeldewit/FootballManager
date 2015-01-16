using RoeldeWit.FootballManager.SqlDataAccess.Classes;

namespace RoeldeWit.FootballManager.ServiceLayer.Repositories
{
    /// <summary>
    /// Football repository
    /// </summary>
    public class FootballRepository : GenericRepository
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public FootballRepository()
            : base(new FootballContext())
        {
        }
    }
}
