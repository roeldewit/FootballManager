using RoeldeWit.FootballManager.Domain.Classes;
using System.Collections.Generic;

namespace RoeldeWit.FootballManager.Domain.Entities
{
    /// <summary>
    /// Country entity
    /// </summary>
    public sealed class Country : EntityBase
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Country()
        {
            Leagues = new HashSet<League>();
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Leagues
        /// </summary>
        public ICollection<League> Leagues { get; set; }
    }
}
