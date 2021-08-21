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
        }
    }
}
