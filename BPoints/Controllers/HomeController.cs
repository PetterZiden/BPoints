using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BPoints.Models;
using BPoints.Models.Services;
using BPoints.Models.Rewards;

namespace BPoints.Controllers
{
    public class HomeController : Controller
    {
        UserService _userService;
        RewardService _rewardService;

        public HomeController(UserService userService, RewardService rewardService)
        {
            _userService = userService;
            _rewardService = rewardService;
        }
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.users = _userService.GetAllUsers();
            return View();
        }

        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.band = _service.GetBandById(id);
            return View();
        }

    }
}
