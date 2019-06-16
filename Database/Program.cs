using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Messages.ConnectingToServer();
            ListActions.FillUsersListWhileDataBaseIsClosed();
            ListActions.FillMessagesListWhileDataBaseIsClosed();
            FileManagementTXT.CreateFilesTXT();
            MainMenu.MainMenuOptions();
        }
       
    }
}
