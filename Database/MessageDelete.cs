using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class MessageDelete
    {
        

        public static void Delete()
        {

            string input;


            do
            {
                Messages.DeleteMessage();
                input = Console.ReadLine();


                switch(input)
                {
                    case "1":
                        UserChooseMessagesFormatDisplay.ChooseMessageFormat();
                        break;


                    case "2":
                        Deleting();
                        break;


                    case "3":
                        break;


                    default:
                        Messages.Wrong_Input();
                        break;
                }


            } while (input != "3");
        }



        private static void Deleting()
        {
            string input;
            int number;


            do
            {
                Messages.DelitingMessage();
                input = Console.ReadLine();


                if( (input != "E") && (input !="e") )
                {
                    if (int.TryParse(input, out number))
                    {
                        if (ListActions.CheckIFMessageIdExistsAndNotDeleted(number))
                            MessageDeleteConfirmation(number);

                    }


                    else
                        Messages.UserMustGiveNumber();
                }

            } while ((input != "E") && (input != "e"));

        }


        private static void MessageDeleteConfirmation(int ID)
        {
            string input;


            do
            {
                Messages.MessageDeleteConfirmation();
                input = Console.ReadLine();

                switch(input)
                {
                    case "Y":
                    case "y":
                        input = "N";
                        DataService.DeleteMessage(ID);
                        Messages.MessageHasBeenDeleted();
                        break;

                    case "N":
                    case "n":
                        break;


                    default:
                        Messages.Wrong_Input();
                        break;
                }


            } while( (input !="N") && (input !="n") );
            
        }

    }
}
