using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnumDropDown.Models;

namespace EnumDropDown.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Game/
        public ActionResult Index(GamesViewModel.GameType? gameType)
        {
            var vm = new GamesViewModel();

            vm.Name = "Francis";
            vm.FavoriteGame = gameType.HasValue ? gameType.Value : GamesViewModel.GameType.EightBall;

            return View(vm);
        }
	}
}