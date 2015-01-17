using RoeldeWit.FootballManager.Domain.Entities;
using System.Collections.Generic;

namespace RoeldeWit.FootballManager.Web.Models
{
    /// <summary>
    /// Details country view model
    /// </summary>
    public class DetailsCountryViewModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Leagues
        /// </summary>
        public IEnumerable<League> Leagues { get; set; }
    }
}