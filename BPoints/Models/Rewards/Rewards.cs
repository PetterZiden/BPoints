using System;
namespace BPoints.Models.Rewards
{
    public class Rewards
    {
        public string RewardName { get; set; }
        public int PointCost { get; set; }

        public Rewards(string rewardName, int pointCost)
        {
            RewardName = rewardName;
            PointCost = pointCost;
        }

        public void RewardAction()
        {
            Console.WriteLine($"You used your {RewardName}");
        }
    }
}
