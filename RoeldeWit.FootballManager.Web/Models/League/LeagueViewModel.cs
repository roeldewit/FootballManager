using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RoeldeWit.FootballManager.Web.Models
{
    /// <summary>
    /// League view model
    /// </summary>
    public class LeagueViewModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Founded at
        /// </summary>
        [Required(ErrorMessage = "{0} is required.")]
        [DisplayName("Founded at")]
        [DataType(DataType.Date)]
        public DateTime Founded { get; set; }

        /// <summary>
        /// Number of teams
        /// </summary>
        [Required(ErrorMessage = "{0} is required.")]
        [DisplayName("Number of teams")]
        public int NumberOfTeams { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required(ErrorMessage = "{0} is required.")]
        public string Name { get; set; }

        /// <summary>
        /// Country id
        /// </summary>
        public int CountryId { get; set; }
    }
}