using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class UserMessage
    {
        private int Id;
        private int SenderID;
        private string SenderName;
        private int ReceiverID;
        private string ReceiverName;
        private string DateOfSubmission;
        private string MessageData;
        private bool MessageDeleted;


        public void InitializeMessage(int _SenderId, string SenderUserName, int _ReceiverID, string _ReceiverName, string _MessageData)
        {
            SenderID = _SenderId;
            SenderName = SenderUserName;
            ReceiverID = _ReceiverID;
            ReceiverName = _ReceiverName;
            DateOfSubmission = Convert.ToString(GetTimeDate.Date() + " " + GetTimeDate.Time());
            MessageData = _MessageData;
            MessageDeleted = false;
        }


        public void SetUpdateDeletedMessage()
        {
            MessageDeleted = true;
        }

        public void setMessageId(int _Id)
        {
            Id = _Id;
        }


        public void setSenderName(string Name)
        {
            SenderName = Name;
        }


        public void setReceiverName(string Name)
        {
            ReceiverName = Name;
        }


        public void setMessageText(string Message)
        {
            MessageData = Message;
        }

        public int GetMessageId()
        {
            return Id;
        }

        public int GetSenderId()
        {
             return SenderID;
        }


        public string GetSenderUserName()
        {
             return SenderName;
        }


        public int GetReceiverId()
        {
             return ReceiverID;
        }


        public string GetReceiverUserName()
        {
            return ReceiverName;
        }


        public string GetDateOfSubmission()
        {
            return DateOfSubmission;
        }


        public string GetMessageData()
        {
            return MessageData;
        }


        public bool GetMessageDeleted()
        {
            return MessageDeleted;
        }

    }


    
}
