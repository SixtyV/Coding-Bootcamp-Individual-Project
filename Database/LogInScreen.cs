using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Database
{
    public static class LogInScreen
    {
       
       
        public static void LogIn(List<User> users)
        {
            string username= String.Empty;   //User name.
            string Password= String.Empty;   //User password.
            bool username_match = false;     //This variable becomes True if the username exists in our database.
            int CurrentUserIndex;            //When a specific user is found, 

            do
            {         
                Messages.LogInMessage(false, username);
                username = Console.ReadLine();

               
                if((username != "E") && (username != "e"))
                {

                    if(InputValidation.UsernamePassword(username))
                    {
                        username_match = ListActions.CheckIfUserNameExists(username, out CurrentUserIndex);

                        if (!username_match)
                            Messages.No_Account_Exists(username);


                        else
                        {


                            if (!users[CurrentUserIndex].GetAccountDeleted())
                            {
                                username_match = false;

                                do
                                {
                                    Console.Clear();
                                    Messages.LogInMessage(true, username);
                                    Password = HidePasswordOnScreen.HidePassword();

                                    if ((Password != "E") && (Password != "e"))
                                    {
                                        if (InputValidation.UsernamePassword(Password))
                                        {

                                            if (DataService.GetUserPassword(users[CurrentUserIndex].GetUserId()) == Password)
                                            {
                                                DataService.ChangeUserLastSignInInDB(users[CurrentUserIndex].GetUserId(), CurrentUserIndex);

                                                List<User> SingleUser = new List<User>();
                                                SingleUser.Add(users[CurrentUserIndex]);

                                                username_match = true;
                                                CreateUserObject.Users(SingleUser);
                                            }


                                            else
                                                Messages.NoPasswordMatch();

                                        }

                                    }


                                    else
                                        username_match = true;


                                } while (!username_match);


                            }


                            else
                                Messages.AccountHasBeenDeleted(username);

                        }

                    }                  

                }
                        
                                               
            } while ((!username_match) && (username != "E") && (username != "e"));
       
        }//LogIn()

    }

}
