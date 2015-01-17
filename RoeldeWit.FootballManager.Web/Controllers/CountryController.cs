using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoeldeWit.FootballManager.Domain.Entities;
using RoeldeWit.FootballManager.ServiceLayer.Repositories;
using RoeldeWit.FootballManager.ServiceLayer.Services;
using RoeldeWit.FootballManager.Web.Models;

namespace RoeldeWit.FootballManager.Web.Controllers
{
    /// <summary>
    /// CountryController
    /// </summary>
    public class CountryController : Controller
    {
        private FootballRepository _footballRepository;

        /// <summary>
        /// Football repository to use
        /// </summary>
        public FootballRepository FootballRepository
        {
            get { return _footballRepository ?? (_footballRepository = new FootballRepository()); }
            set { _footballRepository = value; }
        }

        /// <summary>
        /// Index view with all countries
        /// </summary>
        /// <returns>Index view</returns>
        public ActionResult Index()
        {
            IEnumerable<Country> countries = FootballRepository.ListAll<Country>();

            IndexCountryViewModel viewModel = new IndexCountryViewModel
            {
                Countries = countries
            };

            return View(viewModel);
        }

        /// <summary>
        /// Get details for a specific country
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Details view</returns>
        public ActionResult Details(int id)
        {
            Country country = FootballRepository.Details<Country>(id);

            DetailsCountryViewModel viewModel = new DetailsCountryViewModel
            {
                Name = country.Name,
                Leagues = country.Leagues
            };

            return View(viewModel);
        }

        /// <summary>
        /// Update all countries in the database
        /// </summary>
        /// <returns>Redirect to Index action</returns>
        public ActionResult Update()
        {
            CountryService.UpdateCountries();

            return RedirectToAction("Index", "Country");
        }
    }
}