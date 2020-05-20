using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemoLibrary
{
    public class DisplayMessages
    {

        public string Greeting(string firstName, int hourOfDay)
        {
            string output = "";

            if (hourOfDay < 5)
            {
                output = $"Sleep is good {firstName}";
            }
            else if (hourOfDay < 12)
            {
                output = $"Good morning {firstName}";
            }
            else if (hourOfDay < 18)
            {
                output = $"Good afternoon {firstName}";
            }
            else
            {
                output = $"Good evening {firstName}";
            }

            return output;
        }
    }
}
