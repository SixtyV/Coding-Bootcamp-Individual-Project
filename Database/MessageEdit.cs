using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class MessageEdit
    {
        public static void Edit()
        {

            string input;


            do
            {
                Messages.EditMessage();
                input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        UserChooseMessagesFormatDisplay.ChooseMessageFormat();
                        break;


                    case "2":
                        Editing();
                        break;


                    case "3":
                        break;


                    default:
                        Messages.Wrong_Input();
                        break;
                }


            } while (input != "3");
        }


        private static void Editing()
        {
            string input;
            int number;


            do
            {
                Messages.EditingMessage();
                input = Console.ReadLine();


                if ((input != "E") && (input != "e"))
                {
                    if (int.TryParse(input, out number))
                    {
                        if (ListActions.CheckIFMessageIdExistsAndNotDeleted(number))
                            MessageEditConfirmation(number);

                    }


                    else
                        Messages.UserMustGiveNumber();
                }

            } while ((input != "E") && (input != "e"));

        }



        private static void MessageEditConfirmation(int MessageID)
        {
            string input;
            string MessageText;


            do
            {
               
                Messages.MessageEditConfirmation(ListActions.GetMessageData(MessageID));
                input = Console.ReadLine();

                switch (input)
                {
                    case "Y":
                    case "y":
                        input = "N";
                        Messages.MessageEditText(ListActions.GetMessageData(MessageID));
                        Console.Write("\n ");
                        MessageText = MessageSending.MessageString();
                        DataService.EditMessageText(MessageID, MessageText);
                        Messages.EditMessageSuccesful();
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
