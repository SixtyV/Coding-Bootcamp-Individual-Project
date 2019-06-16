using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Database
{
    public static class FileManagementTXT
    {
 
        private static readonly string FileHistoryLog = "HistoryLog.txt";
        private static readonly string FileMessages = "MessagesLog.txt";


        public static void CreateFilesTXT()
        {
            try
            {
                CreateFileHistoryLog();
                CreateFileMessages();
            }


            catch (Exception)
            {
                Messages.InternalErrorTerminateApplication();
            }

        }



        public static void CreateFileHistoryLog()
        {

            if(!File.Exists(FileHistoryLog))
            {
                var NewFile = File.Create(FileHistoryLog);
                NewFile.Close();
            }
                

        }



        public static void CreateFileMessages()
        {

            if (!File.Exists(FileMessages))
            {
                var NewFile = File.Create(FileMessages);
                NewFile.Close();
            }
                

        }



        public static void HistoryLogEntryCreateAccount(string Name, string Date, string Time)
        {

            
                if (File.Exists(FileHistoryLog))
                {
                    string FileMessage;

                    FileMessage = "\n\n\n --A USER ACOUNT HAS BEEN CREATED--";
                    FileMessage = FileMessage + $"\n User {Name} has been created";
                    FileMessage = FileMessage + $"\n at: {Date}, {Time}";

                    string[] Message = new string[] { FileMessage };
                    File.AppendAllLines(FileHistoryLog, Message);
                }
           
        }


        public static void HistoryLogEntryLogInUpdate(string Name, string DateAndTime)
        {

            
                if (File.Exists(FileHistoryLog))
                {
                    string FileMessage;

                    FileMessage = "\n\n --A USER HAS LOGGED IN--";
                    FileMessage = FileMessage + $"\n User {Name}, logged in \n at: {DateAndTime}";

                    string[] Message = new string[] { FileMessage };
                    File.AppendAllLines(FileHistoryLog, Message);
                }
            

        }



        public static void HistoryLogEntryLogOut(string Name, string DateAndTime)
        {

            
                if (File.Exists(FileHistoryLog))
                {
                    string FileMessage;

                    FileMessage = "\n\n --A USER HAS LOGGED OUT--";
                    FileMessage = FileMessage + $"\n User {Name}, logged out \n at: {DateAndTime}";

                    string[] Message = new string[] { FileMessage };
                    File.AppendAllLines(FileHistoryLog, Message);
                }
            

            
        }



        public static void HistoryLogEntryDeleteAccount(string Name, string DateAndTime)
        {

            
                if (File.Exists(FileHistoryLog))
                {
                    string FileMessage;

                    FileMessage = "\n\n --AN ACCOUNT HAS BEEN DELETED--";
                    FileMessage = FileMessage + $"\n User {Name}, has been deleted \n at: {DateAndTime}";

                    string[] Message = new string[] { FileMessage };
                    File.AppendAllLines(FileHistoryLog, Message);
                }
           

        }



        public static void HistoryLogEntryChangeRights(string Name, int Rights, string DateAndTime)
        {

            
                if (File.Exists(FileHistoryLog))
                {
                    string FileMessage;

                    FileMessage = "\n\n --ACCOUNT USER RIGHTS HAVE BEEN ALTERED--";
                    FileMessage = FileMessage + $"\n User {Name}, rights changed to:";

                    if (Rights == 1)
                        FileMessage = FileMessage + " Minimum\n";

                    else if (Rights == 2)
                        FileMessage = FileMessage + " Basic\n";

                    else if (Rights == 3)
                        FileMessage = FileMessage + " Advanced\n";

                    else if (Rights == 4)
                        FileMessage = FileMessage + " Super Admin\n";


                    FileMessage = FileMessage + $" At: {DateAndTime}";

                    string[] Message = new string[] { FileMessage };
                    File.AppendAllLines(FileHistoryLog, Message);
                }

                     

        }




        public static void MessagesLogEntryStoreMessage(UserMessage NewMessage)
        {

            
                if (File.Exists(FileMessages))
                {
                    string FileMessage;



                    FileMessage = $"\n\n Message ID = {NewMessage.GetMessageId()}";
                    FileMessage = FileMessage + $"\n Sent at  : {NewMessage.GetDateOfSubmission()}";
                    FileMessage = FileMessage + $"\n Sender   : {NewMessage.GetSenderUserName()}";
                    FileMessage = FileMessage + $"\n Receiver : {NewMessage.GetReceiverUserName()}";
                    FileMessage = FileMessage + $"\n Actual Message:\n {NewMessage.GetMessageData()}";

                    string[] Message = new string[] { FileMessage };
                    File.AppendAllLines(FileMessages, Message);
                }
            

           
        }


        public static void DeleteMessage(int MessageID)
        {

            
                if (File.Exists(FileMessages))
                {
                    string FileMessage;

                    FileMessage = $"\n\n --MESSAGE HAS BEEN DELETED--";
                    FileMessage = FileMessage + $"\n Message ID = {MessageID}";
                    FileMessage = FileMessage + $"\n deleted at: {GetTimeDate.TimeAndDate()}";

                    string[] Message = new string[] { FileMessage };
                    File.AppendAllLines(FileMessages, Message);
                }
            
           

        }


        public static void EditMessage(int MessageID, string EditedText)
        {

            
                if (File.Exists(FileMessages))
                {
                    string FileMessage;

                    FileMessage = $"\n\n --MESSAGE HAS BEEN EDITED--";
                    FileMessage = FileMessage + $"\n Message ID = {MessageID}";
                    FileMessage = FileMessage + $"\n edited at: {GetTimeDate.TimeAndDate()}";
                    FileMessage = FileMessage + $"\n edited text:";
                    FileMessage = FileMessage + $"\n {EditedText}";

                    string[] Message = new string[] { FileMessage };
                    File.AppendAllLines(FileMessages, Message);
                }

           
        }
    }
} 
