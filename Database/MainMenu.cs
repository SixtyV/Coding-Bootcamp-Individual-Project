
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class MainMenu
    {

        public static void MainMenuOptions()
        {
            string input;               //User input.
        
            
            do
            {
                Messages.MainMenuScreen();
                input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        if (!ListActions.CheckIfUserListIsEmpty())
                            LogInScreen.LogIn(ListActions.ReturnUsersList());
                        break;


                    case "2":
                        CreateAccountScreen.CreateAccount(ListActions.ReturnUsersList());
                        break;

                   
                    case "3":
                        break;

                    default:
                        Messages.Wrong_Input();
                        break;
                }

            } while (input !="3");
           
        }
       
    }
}
