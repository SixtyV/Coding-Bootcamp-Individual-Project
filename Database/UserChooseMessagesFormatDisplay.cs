using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class UserChooseMessagesFormatDisplay
    {

        public static void ChooseMessageFormat()
        {
            string input;
            bool flag = false;


            do
            {
                Messages.MessageFormatingOptions();
                input = Console.ReadLine();

                switch (input)
                {

                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        ListActions.ShowAllMessagesByGroup(Convert.ToInt32(input));
                        break;


                    case "6":
                        flag = true;
                        break;
                   

                    default:
                        Messages.Wrong_Input();
                        break;
                }


            } while (flag == false);
           
        }
       
            

    }
}
