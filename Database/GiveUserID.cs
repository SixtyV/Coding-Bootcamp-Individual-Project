using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class GiveUserID
    {

        public static bool TypeUserID(int UserID, string Case, out int UpdateUserID)
        {


            string input;            
            int number = 0;
            int CurrentUserIndex = 0;
        

            do
            {

                PrintMenuMessage(Case);
                input = Console.ReadLine();
 

                if ((input != "E") && (input != "e"))
                {
                    if (int.TryParse(input, out number))
                    {


                        if (number != UserID)
                        {

                            if (ListActions.CheckIfUserIdExists(number, out CurrentUserIndex))
                            {

                                if (!ListActions.ReturnSpecificUserAcountDeleted(CurrentUserIndex))
                                {
                                    UpdateUserID = number;
                                    return true;
                                }
                                   



                                else
                                    Messages.AccountHasBeenDeleted(number);

                            }


                            else
                                Messages.No_Account_Exists(number);

                        }

                        else
                            Messages.CannotUpdateYourSelf();



                    }


                    else
                        Messages.UserMustGiveNumber();
                }


            } while ((input != "E") && (input != "e"));

            UpdateUserID = number;
            return false;
        }



        private static void  PrintMenuMessage(string Case)
        {
            if(Case == "Delete")
                Messages.DeleteAccountMessage();


            else if (Case == "UserRights")
                Messages.EditingUserRights();


            else
                Messages.InternalErrorTerminateApplication();
        }


    }
}
