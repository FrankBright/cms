using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.UserAgg
{
    public class UserFactory
    {
        public static UserInfo CreateUser(string userName, string email, string phone)
        {
            var userInfo = new UserInfo()
            {
                UserName = userName,
                Email = email,
                MobilePhoneNumber = phone
            };
            userInfo.GenerateNewIdentity();
            return userInfo;
        }
    }
}
