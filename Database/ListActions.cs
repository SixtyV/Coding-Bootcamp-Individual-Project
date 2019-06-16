using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class ListActions
    {
        static List<User> users = new List<User>();
        static List<UserMessage> messages = new List<UserMessage>();
        


        // USERS LIST METHODS.

        public static void FillUsersListWhileDataBaseIsClosed() //Fills the list directly by the Database. It opens a connection.
        {
            users.Clear();
            users.AddRange(DataService.GetAllUserDetails());
           
        }


        public static void FillUsersListWhileDataBaseIsOpenNewAccount(List<User> user) //Fills the list directly by the Database when a new account is created. Connection with the database is already open.
        {
            
            users.AddRange(user);

        }


        public static void FillUsersListWhileDataBaseIsOpenUpdateUser(int CurrentUserIndex, string DateAndTime)
        {
            users[CurrentUserIndex].SetUserLastLogin(DateAndTime);
        }



        public static void FillUsersDeletedAccountListWhileDataBaseIsOpenUpdateUser(int AccountID)
        {
            foreach (var item in users)
            {
                if (AccountID == item.GetUserId())
                {
                    item.SetUserDeletedAccount();
                    break;
                }

            }
        }



        public static void FillUsersRightsListWhileDataBaseIsOpenUpdateUser(int AccountID, int UserRights)
        {
            foreach (var item in users)
            {
                if (AccountID == item.GetUserId())
                {
                    item.SetUserRights(UserRights);
                    break;
                }

            }
        }




        public static string GetUserNameByID(int AccountID)
        {
            string Name = String.Empty;

            foreach (var item in users)
            {
                if (AccountID == item.GetUserId())
                {
                    Name = item.GetUserName();
                    break;
                }
                    
            }

            return Name;
        }


       
        public static List<User> ReturnUsersList()
        {
            return users;
        }



        public static int ReturnUserListCount()
        {
            return users.Count;
        }



        public static int ReturnSpecificUserID(int CurrentUserIndex)
        {
            return users[CurrentUserIndex].GetUserId();
        }



        public static string ReturnSpecificUserName(int CurrentUserIndex)
        {
            return users[CurrentUserIndex].GetUserName();
        }



        public static bool ReturnSpecificUserAcountDeleted(int CurrentUserIndex)
        {
            return users[CurrentUserIndex].GetAccountDeleted();
        }


        public static bool CheckIfUserListIsEmpty()
        {
            if (users.Count < 1)
            {              
                Messages.DataBaseListIsEmpty();
                return true;

            }

            return false;
           
        }




        public static void PrintUserDetailsLowLevel() //How a simple user sees other users.
        {
            

            if (!CheckIfUserListIsEmpty())
            {
                var NewList = users.OrderBy(user => user.GetUserId()).ToList();
                Messages.ViewUserDetails();



                foreach (var item in NewList)
                {
                    Console.Write($"\n {item.GetUserName()}");
                  

                    if ( (16 - item.GetUserName().Length) >0)
                        Messages.PrintSpaceCharacter(16, item.GetUserName().Length);


                    Console.Write($"  {item.GetUserLastSignIn()}");

                   
                    Messages.PrintSpaceCharacter2(16, 16, item.GetUserLastSignIn().Length);


                    if (item.GetAccountDeleted())
                        Messages.InactiveUser();
                    

                    else
                        Messages.ActiveUser();


                    Console.WriteLine("\n");
                }


                Messages.Key_To_Continue();
            }

        }


        public static void PrintUserDetailsHighLevel()
        {
            

            if (!CheckIfUserListIsEmpty())
            {
                string IdLength;

                var NewList = users.OrderBy(user => user.GetUserId()).ToList();
                Messages.ViewUserDetails2();


                foreach (var item in NewList)
                {
                    IdLength = Convert.ToString(item.GetUserId());

                    Console.Write($"\n {item.GetUserId()}");
                   
                    Messages.PrintSpaceCharacter(5, IdLength.Length);


                    Console.Write($"  {item.GetUserName()}");

                    if ((16 - item.GetUserName().Length) > 0)
                        Messages.PrintSpaceCharacter(16, item.GetUserName().Length);


                  
                    Messages.PrintSpaceCharacter2(5);


                    if (item.GetAccountDeleted())
                    {
                        Messages.InactiveUser();
                        Messages.PrintSpaceCharacter(20, 7);
                    }
                        


                    else
                    {
                        Messages.ActiveUser();
                        Messages.PrintSpaceCharacter(20, 6);
                    }


                    Messages.PrintSpaceCharacter2(5);


                    Console.WriteLine($"{item.GetUserRights()}");

                    Console.WriteLine("\n");
                }


                Messages.Key_To_Continue();
            }
        }



        public static bool CheckIfUserNameExists(string username, out int CurrentUserIndex) //Is used in the log-in screen in order to know if a given
        {                                                                              //username exists, and if it is deleted or not.
                                                                                       //the loop keeps searching and stops only if the given
            bool username_match = false;                                               //username matches and it is not a deleted acount.
            CurrentUserIndex = 0;
            int counter = 0;


            foreach (var item in users)
            {
                
                 if (username == item.GetUserName())
                 {
                    username_match = true;
                    CurrentUserIndex = counter;

                    if (!item.GetAccountDeleted())
                        return username_match;

                }   
                               
                counter++;

            }

            return username_match;

        }



        public static bool CheckIfUserIdExists(int UserID, out int CurrentUserIndex)
        {
            int counter = 0;
            CurrentUserIndex = 0;


            foreach (var item in users)
            {
                if (UserID == item.GetUserId())
                {
                    CurrentUserIndex = counter;
                    return true;
                }

                counter++;

            }

            return false;
        }




        public static bool ScanIfUserIdIsDeleted(int ID) //Scans the users list based on an ID, and if the user ID is a deleted acount returns true.
        {

            foreach (var item in users)
            { 
                if (ID == item.GetUserId())
                {
                    if (item.GetAccountDeleted())
                        return true;                   
                }
            }

            return false;
        }






        public static int GetUserRights(int UserId)
        {
            int UserRights = -1;

            foreach (var item in users)
            {
                if (UserId == item.GetUserId())
                {
                    UserRights = item.GetUserRights();
                    return UserRights;
                }

            }

            if (UserRights == -1)
                Messages.InternalErrorTerminateApplication();


            return UserRights;
        }


      



        //MESSAGES LIST METHODS.

        public static void FillMessagesListWhileDataBaseIsClosed()
        {
            messages.Clear();
            messages.AddRange(DataService.GetAllMessages());
        }


      

        public static void FillMessagesListWhileDataBaseIsOpen(List<UserMessage> message)
        {
            messages.AddRange(message);
        }


       

        public static int GetMessagesListCount()
        {
            return messages.Count;
        }


        

        public static string GetMessageData(int MessageID)
        {
            string message = String.Empty;

            foreach (var item in messages)
            {
                if (MessageID == item.GetMessageId())
                    message = item.GetMessageData();

            }

            return message;
        }



        public static void UpdateDeleteMessageInMessagesList(int MessageID)
        {
            foreach(var item in messages)
            {
                if (MessageID == item.GetMessageId())
                {
                    item.SetUpdateDeletedMessage();
                    break;
                }
                    
            }
        }


        public static void UpdateMessageTextInMessagesList(int MessageID, string MessageText)
        {
            foreach (var item in messages)
            {
                if (MessageID == item.GetMessageId())
                {
                    item.setMessageText(MessageText);
                    break;
                }

            }
        }


        


        public static void UserSentReceivedMessages(int ID, string LoggedInUserName)
        {
            
            List<int> SenderId = new List<int>();                       //Stores the message's sender ID, so there will be no duplicates.
            List<int> ReceiverId = new List<int>();                     //Stores the message's receiver ID, so there will be no duplicates.
            List<bool> Received = new List<bool>();                     //If the user is the receiver of a message becomes true.
            List<UserMessage> ChatRoomList = new List<UserMessage>();

            foreach (var item in messages)
            {
                //If the user is the receiver of the message and the sender is not a deleted account, show the conversation.

                if ( (ID == item.GetReceiverId())  &&  (!ScanIfUserIdIsDeleted(item.GetSenderId())) )
                {
                    
                    if( (!SenderId.Contains(item.GetSenderId())) && (!ReceiverId.Contains(item.GetSenderId())) && (!item.GetMessageDeleted()))
                    {
                        ChatRoomList.Add(item);
                        SenderId.Add(item.GetSenderId());
                        Received.Add(true); //If the user is the receiver of a message becomes true.
                    }


                   
                }


                //If the user is the sender of the message and the receiver is not a deleted account, show the conversation.

                else if ( (ID == item.GetSenderId()) && (!ScanIfUserIdIsDeleted(item.GetReceiverId())))
                {

                    if ((!ReceiverId.Contains(item.GetReceiverId())) && (!SenderId.Contains(item.GetReceiverId())) && (!item.GetMessageDeleted()))
                    {
                        ChatRoomList.Add(item);
                        ReceiverId.Add(item.GetReceiverId());
                        Received.Add(false);  //If the user is the sender of a message becomes false.
                    }

                    
                }
            }

          
            Messages.ChatRoom(ChatRoomList, Received, ID, LoggedInUserName);
        }


        public static void Conversation(int LoggedInUserID, int ConversationUserID) //Conversation messages.
        {
            Console.Clear();

            foreach(var item in messages)
            {
                if (((LoggedInUserID == item.GetReceiverId()) || (LoggedInUserID == item.GetSenderId())) && ((ConversationUserID == item.GetSenderId()) || (ConversationUserID == item.GetReceiverId())) && (!item.GetMessageDeleted()))
                    Messages.PrintConversation(item.GetSenderUserName(), item.GetReceiverUserName(), item.GetDateOfSubmission(), item.GetMessageData());              

            }

            Messages.Key_To_Continue();
        }



        public static void InboxMessages(int LoggedInUserID)
        {
            bool MessagesFound = false;


            Console.Clear();

            foreach (var item in messages)
            {
                if ( (LoggedInUserID == item.GetReceiverId()) && (!item.GetMessageDeleted()))
                {
                    MessagesFound = true;
                    Messages.PrintMailMessage(item.GetMessageId(), item.GetSenderUserName(), item.GetReceiverUserName(), item.GetDateOfSubmission(), item.GetMessageData());

                }
            }


            if (!MessagesFound)
                Messages.InboxIsEmpty();

            else
                Messages.Key_To_Continue();


        }



        public static void SentMessages(int LoggedInUserID)
        {
            bool MessagesFound = false;


            Console.Clear();

            foreach (var item in messages)
            {
                if ((LoggedInUserID == item.GetSenderId()) && (!item.GetMessageDeleted()))
                {
                    MessagesFound = true;
                        Messages.PrintMailMessage(item.GetMessageId(), item.GetSenderUserName(), item.GetReceiverUserName(), item.GetDateOfSubmission(), item.GetMessageData());
                }

            }


            if (!MessagesFound)
                Messages.SentIsEmpty();

            else
                Messages.Key_To_Continue();

        }


        public static void ShowAllMessages() //How simple users can see all the transacted message data among the users.
        {
         
            Console.Clear();

            foreach (var item in messages)
            {
                if(!item.GetMessageDeleted())
                    Messages.PrintMailMessage(item.GetMessageId(), item.GetSenderUserName(), item.GetReceiverUserName(), item.GetDateOfSubmission(), item.GetMessageData());

            }

            Messages.Key_To_Continue();
        }  
        


        public static void ShowAllMessagesByGroup(int input) //How advanced users can see all the transacted message data among the users.
        {
            List<UserMessage> Newlist = new List<UserMessage>();


            if ((messages.Count > 0) && (!CheckIfAllMessangesAreDeleted()))
            {

                if(input == 1)
                    Newlist = messages.OrderBy(p => p.GetMessageId()).ToList();

                else if (input == 2)
                    Newlist = messages.OrderBy(p => p.GetSenderId()).ToList();


                else if (input == 3)
                    Newlist = messages.OrderBy(p => p.GetReceiverId()).ToList();


                else if (input == 4)
                    Newlist = messages.OrderBy(p => p.GetSenderUserName()).ToList();


                else if (input == 5)
                    Newlist = messages.OrderBy(p => p.GetReceiverUserName()).ToList();


                else
                    Messages.InternalErrorTerminateApplication();



                Console.Clear();


                foreach (var item in Newlist)
                {
                    if (!item.GetMessageDeleted())
                        Messages.PrintMailMessage(item.GetMessageId(), item.GetSenderUserName(), item.GetReceiverUserName(), item.GetDateOfSubmission(), item.GetMessageData());

                }

                Messages.Key_To_Continue();

            }


            else
                Messages.NoExistingMessages();

        }



        public static bool CheckIFMessageIdExistsAndNotDeleted(int MessageID)
        {
      
            if (messages.Count > 0)
            {
                foreach (var item in messages)
                {
                    if (MessageID == item.GetMessageId())
                    {
                        if (item.GetMessageDeleted())
                        {
                            Messages.MessageAlreadyDeleted();
                            return false;
                        }
                            

                        else
                            return true;
                        
                    }

                }

                Messages.MessageIdNotFound();

            }


            else
                Messages.NoExistingMessages();

            return false;
           
        }


        public static bool CheckIfAllMessangesAreDeleted()
        {
            foreach (var item in messages)
            {
                if (!item.GetMessageDeleted())
                    return false;

            }

            return true;
        }





    }
}
