using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System.Configuration;

namespace Database
{
    public static class DataService
    {

       


        public static List<User> GetAllUserDetails()
        {

            List<User> user = new List<User>();

            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Setting"].ConnectionString)) //see video How to Use ConnectionString from App config file in Visual Studio C#
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();


                    user.AddRange(db.Query<User>("SELECT * FROM Users").ToList()); 
                }
            }


            catch (Exception)
            {
                Messages.DatabaseConnectionNotFound();
            }

            return user;

        }




        public static string GetUserPassword(int _ID)
        {
            string pass = String.Empty;


            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Setting"].ConnectionString)) //see video How to Use ConnectionString from App config file in Visual Studio C#
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();


                    pass = db.ExecuteScalar<string>("SELECT UserPassword FROM Users WHERE Id = @_ID", new {_ID});

                   
                }
            }


            catch (Exception)
            {
                Messages.DatabaseConnectionNotFound();
            }

            return pass;

        }




        public static void StoreUserDataInDB(string username, string password)
        {
           

            string Name = username;
            string Date = String.Empty;
            string Time = String.Empty;


            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Setting"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    int _Id = db.ExecuteScalar<int>("SELECT Id FROM Users WHERE Id = (SELECT MAX(Id) FROM Users)") + 1;

                    Date = GetTimeDate.Date();
                    Time = GetTimeDate.Time();

                    db.Execute("insert into Users values(@Id, @UserName, @UserPassword, @UserRights, @AccountDeleted, @LastSignIn, @DateSignedUp, @TimeSignedUp)",
                        new
                        {

                            Id = _Id,
                            UserName = username,
                            UserPassword = password,
                            UserRights = 1,
                            AccountDeleted = 0,
                            LastSignIn = "Not signed in",
                            DateSignedUp = Date,
                            TimeSignedUp = Time,


                        });

                    ListActions.FillUsersListWhileDataBaseIsOpenNewAccount(db.Query<User>("SELECT * FROM Users" +
                                                                                          " WHERE Id = @_Id", new { _Id}).ToList());                    

                }


            }


            catch (Exception)
            {
                Messages.DatabaseConnectionNotFound();
            }

            FileManagementTXT.HistoryLogEntryCreateAccount(Name, Date, Time);

        }




        public static void ChangeUserLastSignInInDB(int _ID, int CurrentUserIndex)
        {
            

            string DateAndTime = Convert.ToString( GetTimeDate.Date() + " " + GetTimeDate.Time());

            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Setting"].ConnectionString))
                {


                    if (db.State == ConnectionState.Closed)
                        db.Open();



                    db.Execute("UPDATE Users SET LastSignIn = @DateAndTime  WHERE Id = @_ID",

                    new
                    {
                        DateAndTime,
                        _ID,

                    });


                    ListActions.FillUsersListWhileDataBaseIsOpenUpdateUser(CurrentUserIndex, DateAndTime);
                    

                }

            }


            catch (Exception)
            {
                Messages.DatabaseConnectionNotFound();
            }


            FileManagementTXT.HistoryLogEntryLogInUpdate(ListActions.ReturnSpecificUserName(CurrentUserIndex), DateAndTime);

        }



        public static void DeleteUserAccountInInDB(int _ID)
        {

            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Setting"].ConnectionString))
                {


                    if (db.State == ConnectionState.Closed)
                        db.Open();
                   


                    db.Execute("UPDATE Users SET AccountDeleted = @Deleted  WHERE Id = @_ID",

                    new
                    {
                        Deleted = true,
                        _ID,

                    });


                    ListActions.FillUsersDeletedAccountListWhileDataBaseIsOpenUpdateUser(_ID);
                    

                }

            }


            catch (Exception)
            {
                Messages.DatabaseConnectionNotFound();
            }


            FileManagementTXT.HistoryLogEntryDeleteAccount(ListActions.GetUserNameByID(_ID), GetTimeDate.TimeAndDate());

        }




        public static void EditUserRights(int _ID, int _UserRights)
        {
            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Setting"].ConnectionString))
                {


                    if (db.State == ConnectionState.Closed)
                        db.Open();



                    db.Execute("UPDATE Users SET UserRights = @_UserRights  WHERE Id = @_ID",

                    new
                    {
                        _UserRights,
                        _ID,

                    });


                    ListActions.FillUsersRightsListWhileDataBaseIsOpenUpdateUser(_ID, _UserRights);
                   

                }

            }


            catch (Exception)
            {
                Messages.DatabaseConnectionNotFound();
            }


            FileManagementTXT.HistoryLogEntryChangeRights(ListActions.GetUserNameByID(_ID), _UserRights, GetTimeDate.TimeAndDate());

        }




        //MESSAGES -- ACCESS DATABASE 


        public static List<UserMessage> GetAllMessages()
        {
            List<UserMessage> message = new List<UserMessage>();


            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Setting"].ConnectionString)) //see video How to Use ConnectionString from App config file in Visual Studio C#
                {

                    if (db.State == ConnectionState.Closed)
                        db.Open();


                    message.AddRange(db.Query<UserMessage>("SELECT * FROM UserMessages").ToList());
                }
            }


            catch (Exception)
            {
                Messages.DatabaseConnectionNotFound();
            }

            return message;

        }



        public static void StoreMessageDataInDB(UserMessage NewMessage)
        {

            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Setting"].ConnectionString))
                {


                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    int _Id = db.ExecuteScalar<int>("SELECT Id FROM UserMessages WHERE Id = (SELECT MAX(Id) FROM UserMessages)") + 1;

                    NewMessage.setMessageId(_Id);

                    db.Execute("insert into UserMessages values(@Id, @SenderID , @SenderName, @ReceiverID, @ReceiverName, @DateOfSubmission, @MessageData, @MessageDeleted)",
                        new
                        {
                            Id = NewMessage.GetMessageId(),
                            SenderID = NewMessage.GetSenderId(),
                            SenderName = NewMessage.GetSenderUserName(),
                            ReceiverID = NewMessage.GetReceiverId(),
                            ReceiverName = NewMessage.GetReceiverUserName(),
                            DateOfSubmission = Convert.ToString(GetTimeDate.Date() + " " + GetTimeDate.Time()),
                            MessageData = NewMessage.GetMessageData(),
                            MessageDeleted = NewMessage.GetMessageDeleted(),

                        });


                    ListActions.FillMessagesListWhileDataBaseIsOpen(db.Query<UserMessage>("SELECT * FROM UserMessages" +
                                                                                          " WHERE Id = @_Id", new { _Id })
                                                                                         .ToList());
                    

                }
            }


            catch (Exception)
            {
                Messages.DatabaseConnectionNotFound();
            }

            FileManagementTXT.MessagesLogEntryStoreMessage(NewMessage);

        }





        public static void DeleteMessage(int _ID)
        {

            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Setting"].ConnectionString))
                {


                    if (db.State == ConnectionState.Closed)
                        db.Open();

               

                    db.Execute("UPDATE UserMessages SET MessageDeleted = @Deleted  WHERE Id = @_ID",

                    new
                    {
                        Deleted = true,
                        _ID,

                    });


                    ListActions.UpdateDeleteMessageInMessagesList(_ID);
                    

                }

            }


            catch (Exception)
            {
                Messages.DatabaseConnectionNotFound();
            }


            FileManagementTXT.DeleteMessage(_ID);
        }





        public static void EditMessageText(int _ID, string Text)
        {

            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Setting"].ConnectionString))
                {


                    if (db.State == ConnectionState.Closed)
                        db.Open();

                  
                    db.Execute("UPDATE UserMessages SET MessageData = @Text  WHERE Id = @_ID",

                    new
                    {
                        Text,
                        _ID,
                        
                    });

                    
                    ListActions.UpdateMessageTextInMessagesList(_ID, Text);
                    

                }

            }


            catch (Exception)
            {
                Messages.DatabaseConnectionNotFound();
            }

            FileManagementTXT.EditMessage(_ID, Text);

        }
        
    }
}
