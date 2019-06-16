using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class HidePasswordOnScreen
    {
        public static string HidePassword()
        {
            string Password = String.Empty;
            int PasswordMaxLenght = 16;
            int currentLength = 0;


            ConsoleKeyInfo KeyPressed;

            do
            {
                KeyPressed = Console.ReadKey(true);

                if ( (!char.IsControl(KeyPressed.KeyChar)) && (currentLength < PasswordMaxLenght) )
                {

                    Password += Convert.ToString(KeyPressed.KeyChar);
                    Console.Write("*");
                    currentLength++;
                }


                else if ((KeyPressed.Key == ConsoleKey.Backspace) && (Password.Length > 0))
                {
                    Password = Password.Remove(Password.Length - 1);
                    Console.Write("\b \b");
                    currentLength--;
                }


            } while (KeyPressed.Key != ConsoleKey.Enter);



            return Password;

        }//HidePassword()
    }
}
