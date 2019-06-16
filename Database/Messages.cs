using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class Messages
    {



        public static void Key_To_Continue()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Press any key and then press ENTER to continue... ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

        }//Key_To_Continue()


        public static void Wrong_Input()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --ERROR--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n Wrong input. You should type one of the available options.");
            Key_To_Continue();

        }// Wrong_Input()


        public static void InternalErrorTerminateApplication()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --INTERNAL ERROR--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Something went wrong.");
            Console.WriteLine("\n The application will now terminate.");
            Key_To_Continue();
            Environment.Exit(1);

        }// Wrong_Input()


        public static void MainMenuScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --MAIN MENU--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n 1- Log In as User / Admin.");
            Console.WriteLine("\n 2- Create Account.");
            Console.WriteLine("\n 3- Exit.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void DataBaseListIsEmpty()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --NO ACCOUNTS EXIST--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n There are no existing accounts in the database.");
            Key_To_Continue();

        }


        public static void LogInMessage(bool Flag, string username)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --LOG IN SCREEN--");
            Console.ForegroundColor = ConsoleColor.White;


            if (!Flag)
                TypeUsername();


            else
                TypePassword(username);


        }




        public static void CreateAccountMessage(bool Flag, string username)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --ACCOUNT CREATION--");
            Console.ForegroundColor = ConsoleColor.White;


            if (!Flag)
                TypeUsername();


            else
                TypePassword(username);

        }



        public static void TypeUsername()
        {
            Console.WriteLine("\n\n -Give a username or press 'E' to exit. ");
            Console.WriteLine("\n -A valid username should have more than 3 and less than 16 characters.");
            Console.WriteLine("\n -No spaces are allowed.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n\n USERNAME: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    

        public static void TypePassword(string username)
        {
            Console.WriteLine("\n\n -Give a password or press 'E' to exit. ");
            Console.WriteLine("\n -A valid password should have more than 3 and less than 16 characters.");
            Console.WriteLine("\n -No spaces are allowed.");
            Console.Write($"\n\n\n USERNAME: {username}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n PASSWORD: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void No_Account_Exists(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n --NO SUCH ACCOUNT EXISTS--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n Username {name} could not be found.");
            Key_To_Continue();

        }//No_Account_Exists()


        public static void No_Account_Exists(int UserID)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n --NO SUCH ACCOUNT EXISTS--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n Username with ID = {UserID} could not be found.");
            Key_To_Continue();

        }//No_Account_Exists()


        public static void AccountAlreadyExists(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n --ACCOUNT ALREADY EXISTS--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n Username {name} is already in use. Try another username.");
            Key_To_Continue();

        }//AccountAlreadyExists()


        public static void LogOut(String name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --LOG OUT--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n {name} has been successfully logged out.");
            Key_To_Continue();
        }
    

       

        public static void AccountDeleted(int UserToBeDeleted)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n --ACCOUNT DELETED SUCCESFULLY--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n Username with ID = {UserToBeDeleted} has been deleted.");
            Key_To_Continue();

        }//No_Account_Exists()


        public static void AccountHasBeenDeleted(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --ACCOUNT NO LONGER EXISTS--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n Username {name} has been deleted.");
            Console.WriteLine("\n This account cannot be used.");
            Key_To_Continue();

        }//No_Account_Exists()



        public static void AccountHasBeenDeleted(int UserID)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --ACCOUNT NO LONGER EXISTS--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n Account with ID = {UserID} has been already deleted.");
            Console.WriteLine("\n This account cannot be used.");
            Key_To_Continue();

        }//No_Account_Exists()


        public static void UserDataHasBeenStored(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n --SAVE SUCCESFUL--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n Username {name} has been stored succesfuly.");
            Key_To_Continue();

        }//No_Account_Exists()



        public static void NoPasswordMatch()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n --INVALID PASSWORD--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Incorrect password. Please try again.");
            Key_To_Continue();

        }//No_Account_Exists()


        public static void PasswordMatch(string name, int rights)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --SUCCESSFUL LOGIN--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n Login has completed successfully.");
            Console.WriteLine($"\n Welcome, {name}.");

            if(rights == 1)
                Console.WriteLine("\n Minimum user rights have been granted.");

            else if(rights == 2)
                Console.WriteLine("\n Basic user rights have been granted.");


            else if (rights == 3)
                Console.WriteLine("\n Advanced user rights have been granted.");


            else if (rights == 4)
                Console.WriteLine("\n Super Admin rights have been granted. Hello sir.");


            Key_To_Continue();

        }//No_Account_Exists()



        public static void MenuUser0(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n --USER SCREEN--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n User: {name}.");
            Console.WriteLine("\n\n 1- View existing users.");
            Console.WriteLine("\n 2- View your conversations with other users.");
            Console.WriteLine("\n 3- Check your Inbox & Sent messages.");
            Console.WriteLine("\n 4- Send message to a user.");
            Console.WriteLine("\n 5- Check transacted message data among all the users.");
            Console.WriteLine("\n 6- Play Real Boxing Game.");
            Console.WriteLine("\n 7- Sign out.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void MenuUserAdvanced1(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n --USER SCREEN--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n User: {name}.");
            Console.WriteLine("\n\n 1- View existing users.");
            Console.WriteLine("\n 2- View your conversations with other users.");
            Console.WriteLine("\n 3- Check your Inbox & Sent messages.");
            Console.WriteLine("\n 4- Send message to a user.");
            Console.WriteLine("\n 5- Check transacted message data among all the users.");
            Console.WriteLine("\n 6- Edit Messages.");
            Console.WriteLine("\n 7- Play Real Boxing Game.");
            Console.WriteLine("\n 8- Sign out.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void MenuUserAdvanced2(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n --USER SCREEN--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n User: {name}.");
            Console.WriteLine("\n\n 1- View existing users.");
            Console.WriteLine("\n 2- View your conversations with other users.");
            Console.WriteLine("\n 3- Check your Inbox & Sent messages.");
            Console.WriteLine("\n 4- Send message to a user.");
            Console.WriteLine("\n 5- Check transacted message data among all the users.");
            Console.WriteLine("\n 6- Edit or Delete messages.");
            Console.WriteLine("\n 7- Play Real Boxing Game.");
            Console.WriteLine("\n 8- Sign out.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void MenuUserSuperAdmin(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n --USER SCREEN--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n User: {name}.");
            Console.WriteLine("\n\n 1- View existing users.");
            Console.WriteLine("\n 2- View your conversations with other users.");
            Console.WriteLine("\n 3- Check your Inbox & Sent messages.");
            Console.WriteLine("\n 4- Send message to a user.");
            Console.WriteLine("\n 5- Check transacted message data among all the users.");
            Console.WriteLine("\n 6- Edit or Delete Messages.");
            Console.WriteLine("\n 7- User accounts management.");
            Console.WriteLine("\n 8- Play Real Boxing Game.");
            Console.WriteLine("\n 9- Sign out.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void ViewUsersPreview()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --CHOOSE USERS PREVIEW--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n 1- View last sign in of existing users.");
            Console.WriteLine("\n 2- View the rights of existing users.");
            Console.WriteLine("\n 3- Exit.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void SentReceivedMessagesPreview()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --VIEW YOUR INBOX OR SENT MESSAGES--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n 1- Check Inbox Messages.");
            Console.WriteLine("\n 2- Check Sent Messages.");
            Console.WriteLine("\n 3- Exit.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void EditOrDeleteMessagesPreview()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --EDIT OR DELETE MESSAGES--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n 1- Edit a message.");
            Console.WriteLine("\n 2- Delete a message.");
            Console.WriteLine("\n 3- Exit.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void UserAccountsManagement()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --MANAGE USER ACCOUNTS--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n 1- View existing users info.");
            Console.WriteLine("\n 2- Create a user account.");
            Console.WriteLine("\n 3- Update user rights.");
            Console.WriteLine("\n 4- Delete a user account.");          
            Console.WriteLine("\n 5- Exit.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void ViewUserDetails()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n USERNAME");
            PrintSpaceCharacter(16, 8);
            Console.Write("  LAST SIGN IN");
            PrintSpaceCharacter2(18);
            Console.WriteLine("  ACCOUNT STATUS\n");
            Console.ForegroundColor = ConsoleColor.White;
            
        }



        public static void ViewUserDetails2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n ID");
            PrintSpaceCharacter(5, 2);
            Console.Write("  USER NAME");
            PrintSpaceCharacter(21, 11);
            Console.Write("  ACCOUNT STATUS");
            PrintSpaceCharacter2(9);
            Console.WriteLine("  USER RIGHTS\n");
            Console.ForegroundColor = ConsoleColor.White;

        }



        public static void InactiveUser()
        {
  
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("DELETED");
            Console.ForegroundColor = ConsoleColor.White;

        }


        public static void ActiveUser()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("ACTIVE");
            Console.ForegroundColor = ConsoleColor.White;

        }


        public static void ChatRoom(List<UserMessage> ChatRoomList, List<bool> Received, int LoggedInUserID, string LoggedInUserName)
        {
            string Input;               //User input.
            bool Flag = true;           //While true, the do-while loop will contineu excecuting.
            int ConversationUserID = 0; //The ID of the user who is not logged in.
            bool WrongInput = true;    //If the user has given a non-existing ID becomes true.
                


            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n --CHAT ROOM--");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n\n Welcome to the chat room, {LoggedInUserName}.\n\n");


                if (ChatRoomList.Count > 0)
                {
                    int count = 0;

                    foreach (var item in ChatRoomList)
                    {
                        if (Received[count])
                        {
                            Console.Write($"\n Active conversation with user: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{item.GetSenderUserName()}");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($", ID= ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{item.GetSenderId()}\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                           
                       

                        else
                        {
                            Console.Write($"\n Active conversation with user: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{item.GetReceiverUserName()}");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($", ID= ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{item.GetReceiverId()}\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                            

                        count++;

                    }



                    Console.WriteLine("\n\n -Here you can view all the users with whom you have exchanged messages.");
                    Console.WriteLine("\n -If an account is deleted, the conversation will not be shown here anymore.");
                    Console.WriteLine("\n -If all conversation messages are deleted, the conversation will not be shown.");
                    Console.WriteLine("\n -Type a user ID from the list above in order to open a private conversation.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n -Type an ID from the list above or press 'E' to exit: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Input = Console.ReadLine();


                    if (Input != "E" && Input != "e")
                    {
                        

                        if (ChatRoomList.Count < 1)
                            CharRoomListIsEmpty();


                        else
                        {
                            
                            foreach (var item in ChatRoomList)
                            {
                                if ((Input == Convert.ToString(item.GetSenderId())) && (Input != Convert.ToString(LoggedInUserID)))
                                {
                                    ConversationUserID = item.GetSenderId();
                                    WrongInput = false;
                                    break;
                                }


                                else if ((Input == Convert.ToString(item.GetReceiverId())) && (Input != Convert.ToString(LoggedInUserID)))
                                {
                                    ConversationUserID = item.GetReceiverId();
                                    WrongInput = false;
                                    break;
                                }


                                else
                                    WrongInput = true;

                        
                            }//foreach


                            if (WrongInput)
                                Wrong_Input();


                            else
                                ListActions.Conversation(LoggedInUserID, ConversationUserID);

                        }

                    }

                    else
                        Flag = false;

                }

                else
                {
                    Console.WriteLine(" -The list is empty. You have not exchanged any messages yet.");
                    Console.WriteLine("\n -Here you can view all the users with whom you have exchanged messages.");
                    Console.WriteLine("\n -You must first send or receive a message for the list to be accesible.");
                    Flag = false;
                    Key_To_Continue();
                }
                    
     
            } while (Flag);

        }



        public static void CharRoomListIsEmpty()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --LIST IS EMPTY--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n The list is empty, cannot open private conversations.");
            Key_To_Continue();

        }


        public static void InboxIsEmpty()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --YOUR INBOX IS EMPTY--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n The inbox is empty, no messages found.");
            Key_To_Continue();

        }



        public static void SentIsEmpty()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --NO MESSAGES SENT--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n There are no sent messages.");
            Key_To_Continue();

        }



        public static void PrintMailMessage(int MessageID, string SenderName, string ReceiverName, string DateOfSubmission, string MessageData)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Message ID = ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{ MessageID}");
            Console.WriteLine($"\n Sent at  : {DateOfSubmission}");
            Console.WriteLine($"\n Sender   : {SenderName}");
            Console.WriteLine($"\n Receiver : {ReceiverName}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\n Actual Message:\n\n {MessageData}\n\n\n");
        }
       


        public static void PrintConversation(string SenderUserName, string ReceiverUserName, string DateOfSubmission, string MessageData)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\n --NEW MESSAGE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n {DateOfSubmission}");
            Console.ForegroundColor = ConsoleColor.Yellow;           
            Console.Write($"\n {SenderUserName}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" sent message to:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" {ReceiverUserName}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n {MessageData}\n\n\n");
                    
        }




        public static void UserMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --SEND MESSAGE TO A USER--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n Type a user name in order to send message.");
            Console.WriteLine("\n Or press 'E' to exit \n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Type receiver User Name: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void CannotSendMessageToself()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --MESSAGE CANNOT BE SEND--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n You cannot send messages to youreslf.");
            Key_To_Continue();

        }


        public static void SentMessageSuccesful(string SenderUserName, string ReceiverUserName)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --MESSAGE HAS BEEN SENT SUCCESSFULLY--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n Well done, {SenderUserName}!");
            Console.WriteLine($"\n Your message has been sent to: {ReceiverUserName}");
            Console.WriteLine("\n You will know return to the main menu.");
            Key_To_Continue();
        }


        public static void MessageScreen(string SenderUserName, string CurrentUserName)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --SENDING A MESSAGE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n Message sender   : {SenderUserName}");
            Console.WriteLine($"\n Message Receiver : {CurrentUserName}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\n Type your message (Up to 250 characters) and press ENTER: \n");
            Console.ForegroundColor = ConsoleColor.White;

        }


        public static void MessageFormatingOptions()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --MESSAGES PREVIEW OPTIONS--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n 1- Order messages by message ID.");
            Console.WriteLine("\n 2- Order messages by  sender ID.");
            Console.WriteLine("\n 3- Order messages by  receiver ID.");
            Console.WriteLine("\n 4- Order messages alphabetically by sender name.");
            Console.WriteLine("\n 5- Order messages alphabetically by receiver name.");
            Console.WriteLine("\n 6- Exit and return to the previous screen.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void DeleteMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --DELETE A MESSAGE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n You can delete a message by typing the message ID.");
            Console.WriteLine("\n\n 1- View messages in order to decide which to delete.");
            Console.WriteLine("\n 2- Type the ID of the message you want to delete.");
            Console.WriteLine("\n 3- Exit and return to the previous screen. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void DelitingMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --YOU ARE ABOUT TO DELETE A MESSAGE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n Type the ID of the message you want to delete.");
            Console.WriteLine("\n Press 'E' to exit and return to the previous screen.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n\n Delete message with ID: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void MessageDeleteConfirmation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --MESSAGE DELETE CONFIRMATION--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n Are you sure you want to delete the message?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Press 'Y' to delete or 'N' to exit: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void EditMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --EDIT A MESSAGE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n You can edit a message by typing the message ID.");
            Console.WriteLine("\n\n 1- View messages in order to decide which to edit.");
            Console.WriteLine("\n 2- Type the ID of the message you want to edit.");
            Console.WriteLine("\n 3- Exit and return to the previous screen. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n\n Choose one of the above options: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        



        public static void EditingMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --YOU ARE ABOUT TO EDIT A MESSAGE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n Type the ID of the message you want to edit.");
            Console.WriteLine("\n Press 'E' to exit and return to the previous screen.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n\n Edit message with ID: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void EditMessageSuccesful()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --MESSAGE HAS BEEN EDITED SUCCESSFULLY--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n You have successfully edited the message.");
            Key_To_Continue();
        }


        public static void UserMustGiveNumber()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --ERROR--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n You must type an integer, not a character.");
            Key_To_Continue();
        }


        public static void MessageAlreadyDeleted()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --MESSAGE HAS BEEN ALREADY DELETED--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n This message is already deleted and inaccessible.");
            Key_To_Continue();
        }


       

        public static void MessageEditConfirmation(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --MESSAGE EDIT CONFIRMATION--");
            Console.Write("\n\n Actual message: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{message}");
            Console.WriteLine("\n\n Are you sure you want to edit the message?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Press 'Y' to edit or 'N' to exit: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void MessageEditText(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --MESSAGE TEXT EDIT--");
            Console.Write("\n\n Actual message: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{message}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n Type your text below in order to alter the message:");           
            Console.ForegroundColor = ConsoleColor.White;
        }



        public static void MessageHasBeenDeleted()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --MESSAGE DELETED--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n You have successfully deleted the message.");
            Key_To_Continue();
        }


        public static void MessageIdNotFound()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --MESSAGE DOES NOT EXIST--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n The message does not exist.");
            Key_To_Continue();
        }


        public static void NoExistingMessages()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --THERE ARE NO EXCHANGED MESSAGES--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n No messages have been sent or received.");
            Key_To_Continue();
        }



        public static void DeleteAccountMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --ACCOUNT DELETION--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n You are about to delete a user account. ");
            Console.WriteLine("\n Type a user ID in order to delete it.");
            Console.WriteLine("\n Press 'E' to exit.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Type the ID of the user account to be deleted: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void DeleteUserAccountConfirmationMessage(int UserID)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --ACCOUNT DELETION CONFIRMATION--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n User account with ID =");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" {UserID}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" will be deleted.");
            Console.WriteLine("\n Are you sure you want to edit the message?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Press 'Y' to edit or 'N' to exit: ");
            Console.ForegroundColor = ConsoleColor.White;
        }



        public static void EditingUserRights()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --YOU ARE ABOUT TO CHANGE USER RIGHTS--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n You are about to change user account rights. ");
            Console.WriteLine("\n Type the ID of the user you want to edit.");
            Console.WriteLine("\n Press 'E' to exit and return to the previous screen.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n\n Change user rights of user account with ID: ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void EditingUserRights(int UserID, int UserRights)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --SET USER RIGHTS--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n You are about to change user rights for user with ID = {UserID}.");
            Console.Write($"\n Current user rights: {UserRights} - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintUserRights(UserRights);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n Change current user rights to:");
            Console.WriteLine("\n\n 1- Minimum user rights.");
            Console.WriteLine("\n 2- Basic user rights.");
            Console.WriteLine("\n 3- Advanced user rights.");
            Console.WriteLine("\n 4- Super Admin rights.");                      
            Console.WriteLine("\n Press 'E' to exit and return to the previous screen.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n\n Set user rights: ");
            Console.ForegroundColor = ConsoleColor.White;
        }



        public static void PrintUserRights(int userrights)
        {
            if (userrights == 1)
                Console.WriteLine(" minimum user rights.");


            else if (userrights == 2)
                Console.WriteLine(" basic user rights.");


            else if (userrights == 3)
                Console.WriteLine("advanced user rights.");


            else if (userrights == 4)
                Console.WriteLine("super admin rights.");
        }



        public static void UpdateUserRightsConfirmationMessage(int UserID)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --UPDATE ACCOUNT USER RIGHTS CONFIRMATION--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n User account with ID =");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" {UserID}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" will be updated.");
            Console.WriteLine("\n Are you sure you want to change user rights?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Press 'Y' to edit or 'N' to exit: ");
            Console.ForegroundColor = ConsoleColor.White;
        }



        public static void CannotUpdateYourSelf()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --ACCOUNT UPDATE FAILED--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n You cannot delete or update yourself. ");
            Key_To_Continue();
        }



        public static void UserAlreadyUpdated()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --ACCOUNT UPDATE FAILED--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n Account already matches the specific characteristic. ");
            Key_To_Continue();
        }


        public static void EditUserRightsSuccessful()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n --USER RIGHTS HAVE BEEN EDITED SUCCESSFULLY--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n You have successfully edited the rights of the user.");
            Key_To_Continue();
        }


 

        public static void PrintSpaceCharacter(int limit, int TotalLetters)
        {
           

            for (int k=0;  k < (limit - TotalLetters); k++)
                Console.Write(" ");

        }



        public static void PrintSpaceCharacter2(int TotalSpaces, int limit =0, int TotalLetters =0)
        {

            int Leftspaces = (limit - TotalLetters) * (-1);

            
            for (int k = 0; k < (TotalSpaces - Leftspaces); k++)
                Console.Write(" ");

        }



        public static void No_txt_Found(string File_Name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n --ERROR--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n Cannot find file: {File_Name}");
            Console.Write($"\n {File_Name} will not be updated.");
            Key_To_Continue();

        }// No_txt_Found(string File_Name)



        public static void ApplicationComingSoon()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n COMING SOON...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n Real Boxing Game will be available soon.");
            Console.WriteLine($"\n For more information please contact the software provider at:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n vaxintav@hotmail.com.");
            Console.ForegroundColor = ConsoleColor.White;            
            Key_To_Continue();

        }// No_txt_Found(string File_Name)



        public static void ConnectingToServer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Connecting to the server....");
            Console.ForegroundColor = ConsoleColor.White;
        }



        public static void DatabaseConnectionNotFound()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n -CANNOT CONNECT TO THE SERVER-");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n Connection to the server failed.");
            Console.WriteLine($"\n Please try again later."); 
            Console.WriteLine($"\n The application will now terminate.");
            Key_To_Continue();
            Environment.Exit(1);

        }// No_txt_Found(string File_Name)

    }//Clas
}
