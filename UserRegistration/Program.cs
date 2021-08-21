using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("User Registration\n");

            // Object instantisation
            FormValidate form = new FormValidate();

            // Validate firstname
            form.Form("First Name", form.REGEX_NAME, "* first letter - Capital\n* minimum 3 characters");

            // Validate lastname
            form.Form("Last Name", form.REGEX_NAME, "* first letter - Capital\n* minimum 3 characters");
            
            // Validate email
            form.Form("Email ID", form.REGEX_EMAIL, "E.g. abc.xyz@bl.co.in\n* needs 3 mandatory parts (abc, bl & co)\n* 2 optional(xyz & in)\n* precise @ and .positions");

            // Validate mobile number
            form.Form("Mobile Number (with country code)", form.REGEX_MOBILE, "E.g. 91 1234567890\n* Country code followed by space\n* 10 digit number");

            // Validate password
            form.Form("Password", form.REGEX_PASSWORD, "* minimum 8 characters\n* at least 1 Upper Case");
        }
    }
}
