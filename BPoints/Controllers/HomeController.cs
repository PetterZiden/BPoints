﻿using System;
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
        private readonly UserService _userService;
        private readonly RewardService _rewardService;

        public HomeController(UserService userService, RewardService rewardService)
        {
            _userService = userService;
            _rewardService = rewardService;
        }

        [Route("")]
        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.users = _userService.GetAllUsers();
            return View();
        }

        [HttpGet]
        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            User currentUser = _userService.GetUserById(id);
            int linkedConnectedId = currentUser.ConnectedUserId;
            User linkedUser = _userService.GetUserById(linkedConnectedId);
            ViewBag.user = currentUser;
            ViewBag.linkedUser = linkedUser;
            return View();
        }

        [HttpGet]
        [Route("addpoints/{id}")]
        public IActionResult AddPoints(int id)
        {
            User currentUser = _userService.GetUserById(id);
            int linkedConnectedId = currentUser.ConnectedUserId;
            User linkedUser = _userService.GetUserById(linkedConnectedId);
            ViewBag.user = currentUser;
            ViewBag.linkedUser = linkedUser;

            return View();
        }

        [HttpPost]
        [Route("addpoints/{id}")]
        public IActionResult AddPoints(int id, int Points)
        {
            User currentUser = _userService.GetUserById(id);
            int linkedConnectedId = currentUser.ConnectedUserId;
            User linkedUser = _userService.GetUserById(linkedConnectedId);
            _userService.AddPoints(linkedUser, Points);
            ViewBag.user = currentUser;
            ViewBag.linkedUser = linkedUser;
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("rewards/{id}")]
        public IActionResult Rewards(int id)
        {
            ViewBag.user = _userService.GetUserById(id);
            ViewBag.rewards = _rewardService.GetAllRewards();

            return View();
        }

        [HttpGet]
        [Route("rewards/chosenreward/{id}/{rewardId}")]
        public IActionResult ChosenReward(int id, int rewardId)
        {
            User currentUser = _userService.GetUserById(id);
            Reward currentReward = _rewardService.GetRewardById(rewardId);
            ViewBag.message = _rewardService.BuyReward(currentReward, currentUser);
            ViewBag.user = currentUser;
            ViewBag.reward = currentReward;
            


            return View();
        }
    }
}
