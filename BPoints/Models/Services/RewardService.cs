using System;
using System.Collections.Generic;

namespace BPoints.Models.Rewards
{
    public class RewardService
    {
        private static List<Rewards> rewards = new List<Rewards>
        {
            new RewardMassage { RewardName = "Massage", PointCost = 10 },
        };


    }
}
