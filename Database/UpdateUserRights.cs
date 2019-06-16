using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class UpdateUserRights
    {


        public static void rights(int CurrentUserID)
        {

            int UpdateUserID;


            if (GiveUserID.TypeUserID(CurrentUserID, "UserRights", out UpdateUserID))
                SetUserRights(UpdateUserID);

        }



        private static void SetUserRights(int UpdatedUserID)
        {

            int UpdatedUserRights = ListActions.GetUserRights(UpdatedUserID);
            string input;
            int number;
            int TotalTypesOfUsers =  4;


            do
            {

                Messages.EditingUserRights(UpdatedUserID, UpdatedUserRights);
                input = Console.ReadLine();


                if((input != "E") && (input != "e"))
                {

                    if (int.TryParse(input, out number))
                    {
                        if (UpdatedUserRights == number)
                            Messages.UserAlreadyUpdated();

                        else
                        {
                            if ((number >= 1) && (number <= TotalTypesOfUsers))
                            {
                                if(MessageUserRightsConfirmation(UpdatedUserID, number))
                                    UpdatedUserRights = number;

                            }
                                



                            else
                                Messages.Wrong_Input();

                        }
                    }


                    else
                        Messages.UserMustGiveNumber();
                }
               

            } while ((input != "E") && (input != "e"));           
          
        }


        



        private static bool MessageUserRightsConfirmation(int UserID, int UserRights)
        {
            string input;
            bool ChangedRights = false;


            do
            {

                Messages.UpdateUserRightsConfirmationMessage(UserID);
                input = Console.ReadLine();

                switch (input)
                {
                    case "Y":
                    case "y":
                        input = "E";
                        ChangedRights = true;
                        DataService.EditUserRights(UserID, UserRights);
                        Messages.EditUserRightsSuccessful();                       
                        break;


                    case "N":
                    case "n":
                        input = "E";
                        ChangedRights = false;
                        break;


                    default:
                        Messages.Wrong_Input();
                        ChangedRights = false;
                        break;
                }


            } while ((input != "E") && (input != "e"));

            return ChangedRights;
        }
    }
}
