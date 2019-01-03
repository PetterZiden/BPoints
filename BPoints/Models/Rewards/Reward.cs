using System;
namespace BPoints.Models.Rewards
{
    public class Reward
    {
        public Reward()
        {
                
        }
        public string RewardName { get; set; }
        public int RewardId { get; set; }
        public int PointCost { get; set; }
    }
}
