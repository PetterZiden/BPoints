using System;
namespace BPoints.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int BPoints { get; set; }
        public int ConnectedUserId { get; set; }

        public User(int userId, string userName, int bPoints, int connectedUserId)
        {
            UserId = userId;
            UserName = userName;
            BPoints = bPoints;
            ConnectedUserId = connectedUserId;
            
        }
    }
}
