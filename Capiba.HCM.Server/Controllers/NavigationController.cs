using Capiba.HCM.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Capiba.HCM.Shared.DTOs;
using System.Collections.Generic;

namespace Capiba.HCM.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NavigationController : ControllerBase
    {
        [HttpGet(Name = "SmartNavigation")]
        public List<ListItemDTO> Get()
        {
            var nav = NavigationModel.BuildNavigation();
            List<ListItemDTO> _nav = nav.Lists;
            return _nav;
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
