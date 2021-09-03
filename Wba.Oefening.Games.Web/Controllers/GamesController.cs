using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Games.Core;

namespace Wba.Oefening.Games.Web.Controllers
{

    public class GamesController : Controller
    {
        private readonly GameRepository gameRepository;

        public GamesController()
        {
            gameRepository = new GameRepository();
        }

        [Route("games")]
        [Route("games/all")]

        public IActionResult Index()
        {
            return Content("I should make a view + view model for this!");
        }

        [Route("games/{id}")]
        public IActionResult ShowGame(int id)
        {
            return Content("I should make a view + view model for this!");
        }

    }
}