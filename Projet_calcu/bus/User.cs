using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_calcu.bus
{
    public class User
    {
        private int userId;
        private string userName;

       public int UserId { get { return userId; } set { this.userId = value; } }
       public string UserName { get { return userName; } set { this.userName = value; } }

        public User() 
        { 
            this.UserId = 0;
            this.userName = "Jhon Doe";
        }

        public User(int userId, string userName) 
        {
            this.userId = userId;
            this.userName = userName;
        }

        public string GetUserNameState() 
        {
            string state;
            state = this.userId + " | " + this.userName;
            return state; 
        
        }
        
        
    }
}
