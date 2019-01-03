using System;
using System.Collections.Generic;
using System.Linq;
using BPoints.Models.Services;

namespace BPoints.Models.Rewards
{
    public class RewardService
    {
        private static readonly List<Reward> rewards = new List<Reward>
        {
            new RewardMassage{ RewardId = 1, RewardName = "Massage", PointCost = 20},
            new RewardDinner { RewardId = 2, RewardName = "Dinner",PointCost = 50}
        };

        private UserService _userService;

        public RewardService(UserService userService)
        {
            _userService = userService;
        }

        public Reward[] GetAllRewards() => rewards.ToArray();

        public Reward GetRewardById(int id) => rewards.FirstOrDefault(b => b.RewardId == id);

        public string BuyReward(Reward reward, User user)
        {
            if (reward.PointCost > user.BPoints)
            {
                return "You dont have enough points";
            }
            else
            {
                user.BPoints -= reward.PointCost;
                _userService.AddRewardToGet(user, reward);
                return $"You cashed in a {reward.RewardName}, it cost you {reward.PointCost} points, you have {user.BPoints} left.";
            }
        }

    }
}
