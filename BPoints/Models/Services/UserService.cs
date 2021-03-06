﻿using BPoints.Models.Rewards;
using System.Collections.Generic;
using System.Linq;

namespace BPoints.Models.Services
{
    public class UserService
    {
        private static List<User> users = new List<User>
        {
            new User { UserId = 1, UserName = "Petter", BPoints = 10, ConnectedUserId = 2 },
            new User { UserId = 2, UserName = "Alma", BPoints = 5, ConnectedUserId = 1 },
        };

        public User GetUserById(int id) => users.FirstOrDefault(b => b.UserId == id);


        public User[] GetAllUsers() => users.ToArray();

        public void AddPoints(User user, int pointsToAdd)
        {
            user.BPoints += pointsToAdd;

        }

        public void AddRewardToGet(User user, Reward reward)
        {
            user.RewardsToGet.Add(reward);
            User linkedUser = GetUserById(user.ConnectedUserId);
            linkedUser.RewardsToDo.Add((reward));

        }
    }
}

