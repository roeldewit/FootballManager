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
    /// <summary>
    /// LeagueController
    /// </summary>
    public class LeagueController : Controller
    {
        private FootballRepository _footballRepository;

        /// <summary>
        /// FootballRepository to use
        /// </summary>
        public FootballRepository FootballRepository
        {
            get { return _footballRepository ?? (_footballRepository = new FootballRepository()); }
            set { _footballRepository = value; }
        }

        /// <summary>
        /// Index
        /// </summary>
        /// <returns>Index view</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Create a view model for a new league
        /// </summary>
        /// <param name="countryId">Country id</param>
        /// <returns>Create view</returns>
        [HttpGet]
        public ActionResult Create(int countryId)
        {
            LeagueViewModel viewModel = new LeagueViewModel
            {
                CountryId = countryId
            };

            return View(viewModel);
        }

        /// <summary>
        /// Create a new league
        /// </summary>
        /// <param name="viewModel">LeagueViewModel</param>
        /// <returns>Redirect to Country details</returns>
        [HttpPost]
        public ActionResult Create(LeagueViewModel viewModel)
        {
            ActionResult result = View(viewModel);

            if (ModelState.IsValid)
            {
                League league = new League
                {
                    Name = viewModel.Name,
                    NumberOfTeams = viewModel.NumberOfTeams,
                    Founded = viewModel.Founded,
                    CountryId = viewModel.CountryId
                };

                FootballRepository.Insert(league);
                FootballRepository.Save();

                result = RedirectToAction("Details", "Country", new { id = viewModel.CountryId });
            }

            return result;
        }
    }
}