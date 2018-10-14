using System;
namespace BPoints.Models.Services
{
    public class RewardService
    {
        public RewardService()
        {
            User u1 = new User(1, "Petter", 10, 2);
            User u2 = new User(2, "Alma", 10, 1);

        }

        public void addPoints(User user)
        {
            int userToReward = user.ConnectedUserId;

        }
    }
}
