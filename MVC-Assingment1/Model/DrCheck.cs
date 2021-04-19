using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assingment1.Model
{
    public class DrCheck
    {
        public static string   Doctor(double temp )
        {
            if (temp <=38.1)
            {
                return "du har inte någon feber";
            
            }
            else
            {

                return "Du har fever";
            }
            
        }
    }
}
