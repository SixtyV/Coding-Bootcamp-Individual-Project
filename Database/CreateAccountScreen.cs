using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class CreateAccountScreen
    {
        public static void CreateAccount(List<User> users)
        {
            string Username = String.Empty;  //User name.
            string Password= String.Empty;   //User password.
            bool username_match = false;     //This variable becomes True if the username exists in our database.
            int counter;


            do
            {

                Messages.CreateAccountMessage(false, Username);
                Username = Console.ReadLine();


                if ((Username != "E") && (Username != "e"))
                {
                   if(InputValidation.UsernamePassword(Username))
                    {
                        username_match = ListActions.CheckIfUserNameExists(Username, out counter);

                        if ((!username_match) || (username_match && (users[counter].GetAccountDeleted())))
                        {

                            do
                            {
                                Messages.CreateAccountMessage(true, Username);
                                Password = HidePasswordOnScreen.HidePassword();

                                if ((Password != "E") && (Password != "e"))
                                {
                                    if (InputValidation.UsernamePassword(Password))
                                    {
                                        DataService.StoreUserDataInDB(Username, Password);
                                        Messages.UserDataHasBeenStored(Username);
                                        username_match = true;
                                    }


                                }


                                else
                                    username_match = true;


                            } while (!username_match); 
                            

                            
                        }

                        else if (username_match && (!users[counter].GetAccountDeleted()))
                        {
                            username_match = false;
                            Messages.AccountAlreadyExists(Username);
                        }

                    }
                        
                }
                                      
            } while ((!username_match) && (Username != "E") && (Username != "e"));
        }

        

    }
}
