using RoeldeWit.FootballManager.Domain.Entities;
using System.Collections.Generic;

namespace RoeldeWit.FootballManager.Web.Models
{
    /// <summary>
    /// Index country view model
    /// </summary>
    public class IndexCountryViewModel
    {
        /// <summary>
        /// Countries
        /// </summary>
        public IEnumerable<Country> Countries { get; set; }
    }
}