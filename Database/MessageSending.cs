using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class MessageSending
    {
        
        public static string MessageString()
        {
            string TextMessage;
            int MessageMaxLenght = 250;


            TextMessage = Console.ReadLine();


            if (TextMessage.Length < 1)
                return "The sender sent an empty Message";


            else if (TextMessage.Length > MessageMaxLenght)
                return TextMessage.Substring(0, MessageMaxLenght);


            return TextMessage;


        }
    }

}
