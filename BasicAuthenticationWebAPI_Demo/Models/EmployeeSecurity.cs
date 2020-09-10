using BasicAuthenticationWebAPI_Demo.Data;
using System;
using System.Linq;

namespace BasicAuthenticationWebAPI_Demo.Models
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Users.Any(user => user
                .Username.Equals(username, StringComparison
                .OrdinalIgnoreCase) && user
                .Password == password);
            }
        }
    }
}