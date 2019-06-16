using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class CreateUserObject
    {

        public static void Users(List<User> SingleUser)
        {
            switch(SingleUser[0].GetUserRights())
            {
                case 1:
                    User user = new User();
                    user.InitializeObject(SingleUser);
                    Messages.PasswordMatch(user.GetUserName(), user.GetUserRights());
                    user.UserMenu();
                    break;


                case 2:
                    UserAdvanced1 useradvanced1 = new UserAdvanced1();
                    useradvanced1.InitializeObject(SingleUser);
                    Messages.PasswordMatch(useradvanced1.GetUserName(), useradvanced1.GetUserRights());
                    useradvanced1.UserMenu();
                    break;


                case 3:
                    UserAdvanced2 useradvanced2 = new UserAdvanced2();
                    useradvanced2.InitializeObject(SingleUser);
                    Messages.PasswordMatch(useradvanced2.GetUserName(), useradvanced2.GetUserRights());
                    useradvanced2.UserMenu();
                    break;


                case 4:
                    UserSuperAdmin useradmin = new UserSuperAdmin();
                    useradmin.InitializeObject(SingleUser);
                    Messages.PasswordMatch(useradmin.GetUserName(), useradmin.GetUserRights());
                    useradmin.UserMenu();
                    break;


                default:
                    Messages.InternalErrorTerminateApplication();
                    break;
            }
        }

    }
}



