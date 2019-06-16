using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class UserAdvanced1 : User
    {
        override public void  UserMenu()
        {
            string Input;

            do
            {
                Messages.MenuUserAdvanced1(UserName);
                Input = Console.ReadLine();

                switch (Input)
                {

                    case "1":
                        ListActions.PrintUserDetailsLowLevel();
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
                        if ((ListActions.GetMessagesListCount() > 0) && (!ListActions.CheckIfAllMessangesAreDeleted()))
                            MessageEdit.Edit();

                        else
                            Messages.NoExistingMessages();
                        break;


                    case "7":
                        Messages.ApplicationComingSoon();
                        break;


                    case "8":
                        FileManagementTXT.HistoryLogEntryLogOut(UserName, GetTimeDate.TimeAndDate());
                        Messages.LogOut(UserName);
                        break;


                    default:
                        Messages.Wrong_Input();
                        break;
                }

            } while (Input != "8");
        }


    }
}
