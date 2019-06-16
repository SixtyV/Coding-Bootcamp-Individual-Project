using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class User
    {

     
        protected int Id;
        protected string UserName; 
        protected string UserPassword;
        protected int UserRights;
        protected bool AccountDeleted;
        protected string LastSignIn;
        protected string DateSignedUp;
        protected string TimeSignedUp;


        public void InitializeObject(List<User> SingleUser)
        {
            Id = SingleUser[0].GetUserId();
            UserName = SingleUser[0].GetUserName();
            UserPassword = SingleUser[0].GetUserPassword();
            UserRights = SingleUser[0].GetUserRights();
            AccountDeleted = SingleUser[0].GetAccountDeleted();
            LastSignIn = SingleUser[0].GetUserLastSignIn();
            DateSignedUp = SingleUser[0].GetUserDateSignedUp();
            TimeSignedUp = SingleUser[0].GetUserTimeSignedUp();
        }


        public void SetUserLastLogin(string DateAndTime)
        {
            LastSignIn = DateAndTime;
        }


        public void SetUserDeletedAccount()
        {
            AccountDeleted = true;
        }


        public void SetUserRights(int Rights)
        {
            UserRights = Rights;
        }


        public void SetUserName(String Name)
        {
            UserName = Name;
        }


        virtual public void UserMenu()
        {
            string Input;

            do
            {
                Messages.MenuUser0(UserName);
                Input = Console.ReadLine();

                switch(Input)
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
                            ListActions.ShowAllMessages();

                        else
                            Messages.NoExistingMessages();
                        break;


                    case "6":
                        Messages.ApplicationComingSoon();
                        break;


                    case "7":
                        FileManagementTXT.HistoryLogEntryLogOut(UserName, GetTimeDate.TimeAndDate());
                        Messages.LogOut(UserName);
                        break;

                        

                    default:
                        Messages.Wrong_Input();
                        break;
                }

            } while (Input != "7");
        }




        protected void SentReceivedMessages(int Id)
        {
            String Input;


            do
            {
                Messages.SentReceivedMessagesPreview();
                Input = Console.ReadLine();



                switch (Input)
                {
                    case "1":
                        ListActions.InboxMessages(Id);
                        break;


                    case "2":
                        ListActions.SentMessages(Id);
                        break;


                    case "3":
                        break;


                    default:
                        Messages.Wrong_Input();
                        break;


                }


            } while (Input != "3");

        }



        protected void SendMessage()
        {
            string input;           //user message.
            int CurrentUserIndex;   //The index if the receiver user.
            string MessageData;     //The actual message.
             
            do
            {
                Messages.UserMessage();
                input = Console.ReadLine();

                if( (input != "E") && (input != "e") )
                {
                     
                   if (InputValidation.UsernamePassword(input))
                   {
                       
                        
                        if (!ListActions.CheckIfUserNameExists(input, out CurrentUserIndex))
                            Messages.No_Account_Exists(input);


                        else
                        {
                            if (input == UserName)
                                Messages.CannotSendMessageToself();

                            else
                            {
                                if (!ListActions.ReturnSpecificUserAcountDeleted(CurrentUserIndex))
                                {
                                    Messages.MessageScreen(UserName, ListActions.ReturnSpecificUserName(CurrentUserIndex));
                                    MessageData = MessageSending.MessageString();


                                    UserMessage NewMessage = new UserMessage();
                                    NewMessage.InitializeMessage(Id, UserName, ListActions.ReturnSpecificUserID(CurrentUserIndex), ListActions.ReturnSpecificUserName(CurrentUserIndex), MessageData);
                                    

                                    DataService.StoreMessageDataInDB(NewMessage);

                                    input = "E";
                                    Messages.SentMessageSuccesful(UserName, NewMessage.GetReceiverUserName());
                                }
                                    

                                else
                                    Messages.AccountHasBeenDeleted(input);
                            }
                        }
                      

                   }                 
                    
                }


            } while (input != "E" && input != "e");
        }


        

        protected void UserChatRoom()
        {          
            ListActions.UserSentReceivedMessages(Id, UserName);
        }


        public void GetUserInformation()
        {
            Console.Clear();
            Console.WriteLine($" {Id}, {UserName}, {UserPassword}, {UserRights}, {AccountDeleted}, {DateSignedUp}, {TimeSignedUp}");
            Console.ReadLine();
        }


        public int GetUserId()
        {
            return Id;

        }


        public string GetUserName()
        {
            return UserName;

        }


        public string GetUserPassword()
        {
            return UserPassword;

        }


        public int GetUserRights()
        {
            return UserRights;

        }


        public bool GetAccountDeleted()
        {
            return AccountDeleted;

        }


        public string GetUserLastSignIn()
        {
            return LastSignIn;

        }

        public string GetUserDateSignedUp()
        {
            return DateSignedUp;

        }


        public string GetUserTimeSignedUp()
        {
            return TimeSignedUp;

        }

    }

}
