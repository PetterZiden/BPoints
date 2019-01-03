using BPoints.Models.Rewards;
using System.Collections.Generic;
namespace BPoints.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int BPoints { get; set; }
        public int ConnectedUserId { get; set; }
        public List<Reward> RewardsToDo = new List<Reward>();
        public List<Reward> RewardsToGet = new List<Reward>();

    }
}
