using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPoints.Models.Services
{
    public class UserService
    {
        private static List<User> users = new List<User>
        {
            new User { UserId = 1, UserName = "Petter", BPoints = 10, ConnectedUserId = 2 },
            new User { UserId = 2, UserName = "Alma", BPoints = 5, ConnectedUserId = 1 },
        };

        public User GetUserById(int id) => users.Single(b => b.UserId == id);


        public User[] GetAllUsers() => users.ToArray();

        public void addPoints(User user)
        {
            int userToReward = user.ConnectedUserId;

        }

    }
}

