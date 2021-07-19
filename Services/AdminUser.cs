using System;
using IServices;

namespace Services
{
    public class AdminUser : IAdminUser
    {
        public bool Login(string name, string pwd)
        {
            return name == "admin" && pwd == "123";
        }
    }
}
