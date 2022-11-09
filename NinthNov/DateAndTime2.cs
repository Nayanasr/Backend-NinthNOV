using System;
using System.Collections.Generic;
using System.Text;

namespace NinthNov
{
    public class DateAndTime2
    {
        //DateTime dateTime = new DateTime();

        public string wishing;
        public string datetime() {

            DateTime time = DateTime.Now;

            if (time.Hour >= 5 && time.Hour<12) {
                wishing = "Good Morning";
               //Console.WriteLine(Convert.ToString(DateTime.Now));
            }
            else if (time.Hour >= 12 && time.Hour <= 4) {
              wishing = "Good Afternoon";
                
            }
            else {
                wishing = "Good Evening";
            }
            Console.WriteLine(wishing);
            return wishing;
        }

    }

    
}
