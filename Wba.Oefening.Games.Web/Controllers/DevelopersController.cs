using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Games.Domain;

namespace Wba.Oefening.Games.Web.Controllers
{
    public class DevelopersController : Controller
    {
        private readonly DeveloperRepository developerRepository;

        public DevelopersController()
        {
            //initialize service classes
            developerRepository = new DeveloperRepository();
        }

        [Route("developers")]
        [Route("developers/all")]
        public IActionResult Index()
        {
            return Content("I should make a view + view model for this!");
        }

        [Route("developers/{id}")]
        public IActionResult ShowDeveloper(int id)
        {
            return Content("I should make a view + view model for this!");
        }

    }
}