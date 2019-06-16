using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Database
{
    public static class GetTimeDate
    {

        public static string Time()
        {
            return DateTime.Now.ToString("hh:mm:ss tt", new CultureInfo("en-US"));

        }//Time()


        public static string Date()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");

        }//Date()


        public static string TimeAndDate()
        {
            return DateTime.Now.ToString("dd/MM/yyyy, hh:mm:ss tt", new CultureInfo("en-US"));

        }//TimeAndDate()


    }
}
