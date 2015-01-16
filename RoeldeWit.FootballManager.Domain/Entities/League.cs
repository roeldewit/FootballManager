using RoeldeWit.FootballManager.Domain.Classes;
using System;
using System.Collections.Generic;

namespace RoeldeWit.FootballManager.Domain.Entities
{
    /// <summary>
    /// League entity
    /// </summary>
    public sealed class League : EntityBase
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public League()
        {
            Clubs = new HashSet<Club>();
        }

        /// <summary>
        /// Founded at
        /// </summary>
        public DateTime Founded { get; set; }

        /// <summary>
        /// Number of teams
        /// </summary>
        public int NumberOfTeams { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Clubs
        /// </summary>
        public ICollection<Club> Clubs { get; set; }

        /// <summary>
        /// Current champion
        /// </summary>
        public Club CurrentChampion { get; set; }
    }
}
