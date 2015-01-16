using Newtonsoft.Json.Linq;
using RoeldeWit.FootballManager.Domain.Entities;
using RoeldeWit.FootballManager.ServiceLayer.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace RoeldeWit.FootballManager.ServiceLayer.Services
{
    /// <summary>
    /// Class containing the CountryService
    /// </summary>
    public static class CountryService
    {
        /// <summary>
        /// Update all countries
        /// </summary>
        public static void UpdateCountries()
        {
            IEnumerable<string> countryNames = GetCountryNames();
            IEnumerable<Country> countries = MapCountryNamesToEntities(countryNames);

            SaveCountries(countries);
        }

        /// <summary>
        /// Get all country names via a RESTful API
        /// </summary>
        /// <returns>Collection of country names</returns>
        private static IEnumerable<string> GetCountryNames()
        {
            IEnumerable<string> countryNames = new List<string>();

            WebRequest request = WebRequest.Create(new Uri("http://restcountries.eu/rest/v1"));

            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            if (dataStream != null)
            {
                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();

                reader.Close();
                response.Close();

                JArray jsonReponse = JArray.Parse(responseFromServer);

                countryNames = jsonReponse.Select(jToken => jToken.SelectToken("name").ToString());
            }

            return countryNames;
        }

        /// <summary>
        /// Map a collection of country names to country entities
        /// </summary>
        /// <param name="countryNames">Collection of country names</param>
        /// <returns>Collection of country entities</returns>
        private static IEnumerable<Country> MapCountryNamesToEntities(IEnumerable<string> countryNames)
        {
            IEnumerable<Country> countries = countryNames.Select(countryName => new Country
            {
                Name = countryName
            });

            return countries;
        }

        /// <summary>
        /// Save a collection of countries
        /// </summary>
        /// <param name="countries">Collection of countries</param>
        private static void SaveCountries(IEnumerable<Country> countries)
        {
            FootballRepository footballRepository = new FootballRepository();

            IEnumerable<Country> existingCountries = footballRepository.ListAll<Country>();

            foreach (Country newCountry in countries)
            {
                Country country = existingCountries.SingleOrDefault(item => item.Name == newCountry.Name);

                if (country == null)
                    footballRepository.Insert(newCountry);
            }

            footballRepository.Save();
        }
    }
}
