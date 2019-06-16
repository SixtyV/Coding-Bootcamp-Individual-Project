using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class UserAdvanced2 : UserAdvanced1
    {


        override public void UserMenu()
        {
            string Input;

            do
            {
                Messages.MenuUserAdvanced2(UserName);
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
                        EditOrDeleteMessage();
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




        protected void EditOrDeleteMessage()
        {
            String Input;


            do
            {
                Messages.EditOrDeleteMessagesPreview();
                Input = Console.ReadLine();


                switch (Input)
                {
                    case "1":
                        if ((ListActions.GetMessagesListCount() > 0) && (!ListActions.CheckIfAllMessangesAreDeleted()))
                            MessageEdit.Edit();


                        else
                            Messages.NoExistingMessages();
                        break;



                    case "2":
                        if ((ListActions.GetMessagesListCount() > 0) && (!ListActions.CheckIfAllMessangesAreDeleted()))
                            MessageDelete.Delete();


                        else
                            Messages.NoExistingMessages();
                        break;



                    case "3":
                        break;
                       


                    default:
                        Messages.Wrong_Input();
                        break;


                }


            } while (Input != "3");

        }
    }
}