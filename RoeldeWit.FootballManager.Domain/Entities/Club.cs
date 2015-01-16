using RoeldeWit.FootballManager.Domain.Classes;
using System;

namespace RoeldeWit.FootballManager.Domain.Entities
{
    /// <summary>
    /// Club entity
    /// </summary>
    public class Club : EntityBase
    {
        /// <summary>
        /// Full name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Short name
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Founded at
        /// </summary>
        public DateTime Founded { get; set; }

        /// <summary>
        /// Ground
        /// </summary>
        public string Ground { get; set; }
    }
}
