using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class UserSuperAdmin : UserAdvanced2
    {

        override public void UserMenu()
        {
            string Input;

            do
            {
                Messages.MenuUserSuperAdmin(UserName);
                Input = Console.ReadLine();

                switch (Input)
                {

                    case "1":
                        UsersPreview();
                        break;


                    case "2":
                        UserChatRoom();
                        break;


                    case "3":
                        SentReceivedMessages(Id);
                        break;


                    case "4":
                        SendMessage();
                        break;


                    case "5":
                        if ((ListActions.GetMessagesListCount() > 0) && (!ListActions.CheckIfAllMessangesAreDeleted()))
                            UserChooseMessagesFormatDisplay.ChooseMessageFormat();

                        else
                            Messages.NoExistingMessages();
                        break;



                    case "6":
                        EditOrDeleteMessage();
                        break;


                        
                    case "7":
                        UsersAccountManagement();
                        break;



                    case "8":
                        Messages.ApplicationComingSoon();
                        break;


                    case "9":
                        FileManagementTXT.HistoryLogEntryLogOut(UserName, GetTimeDate.TimeAndDate());
                        Messages.LogOut(UserName);
                        break;


                    default:
                        Messages.Wrong_Input();
                        break;
                }

            } while (Input != "9");
        }




        private void UsersPreview()
        {
            String Input;


            do
            {
                Messages.ViewUsersPreview();
                Input = Console.ReadLine();

               
                switch (Input)
                {
                    case "1":
                        ListActions.PrintUserDetailsLowLevel();
                        break;


                    case "2":
                        ListActions.PrintUserDetailsHighLevel();
                        break;


                    case "3":
                        break;


                    default:
                        Messages.Wrong_Input();
                        break;

                    
                }


            } while (Input != "3");

        }


            
        private void UsersAccountManagement()
        {
            String Input;


            do
            {
                Messages.UserAccountsManagement();
                Input = Console.ReadLine();



                switch (Input)
                {
                    case "1":
                        ListActions.PrintUserDetailsHighLevel();        
                        break;


                    case "2":
                        CreateAccountScreen.CreateAccount(ListActions.ReturnUsersList());
                        break;


                    case "3":
                        UpdateUserRights.rights(Id);
                        break;


                    case "4":
                        DeleteUserAccount.AccountDeleting(Id);
                        break;


                    case "5":
                        break;


                    default:
                        Messages.Wrong_Input();
                        break;

                    
                }


            } while (Input != "5");

        }


   

    }

}




    