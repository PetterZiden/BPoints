using System;
using System.Collections.Generic;

namespace BPoints.Models.Rewards
{
    public class RewardService
    {
        private static readonly List<Rewards> rewards = new List<Rewards>
        {
            new RewardMassage { RewardName = "Massage", PointCost = 10 },
        };

        public void UseReward(Rewards reward, User user)
        {
            int rewardPointCost = reward.PointCost;

            if (rewardPointCost > user.BPoints)
            {
                Console.WriteLine("You dont have enough points");
            }
            else
            {
                user.BPoints -= rewardPointCost;
            }
        }

    }
}
