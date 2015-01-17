using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoeldeWit.FootballManager.Domain.Entities;
using RoeldeWit.FootballManager.ServiceLayer.Repositories;
using RoeldeWit.FootballManager.Web.Models;

namespace RoeldeWit.FootballManager.Web.Controllers
{
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

        // GET: Country
        public ActionResult Index()
        {
            IEnumerable<Country> countries = FootballRepository.ListAll<Country>();

            IndexCountryViewModel viewModel = new IndexCountryViewModel
            {
                Countries = countries
            };

            return View(viewModel);
        }

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
    }
}