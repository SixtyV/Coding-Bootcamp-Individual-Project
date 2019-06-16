using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class DeleteUserAccount
    {


        public static void AccountDeleting(int CurrentUserID)
        {
            int DeleteUserID;


            if (GiveUserID.TypeUserID(CurrentUserID, "Delete", out DeleteUserID))
                DeleteAcountConfirmation(DeleteUserID);
        }


        

        private static void DeleteAcountConfirmation(int UserToBeDeleted)
        {
            
            string input;


            do
            {
                Messages.DeleteUserAccountConfirmationMessage(UserToBeDeleted);
                input = Convert.ToString(Console.ReadLine());

                switch (input)
                {
                    case "Y":
                    case "y":
                        input = "N";
                        DataService.DeleteUserAccountInInDB(UserToBeDeleted);
                        Messages.AccountDeleted(UserToBeDeleted);
                        break;

                    case "N":
                    case "n":
                        break;


                    default:
                        Messages.Wrong_Input();
                        break;
                }


            } while ((input != "N") && (input != "n"));
        }
       
    }
}
