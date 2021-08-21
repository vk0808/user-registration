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

            // Validate lasstname
            form.Form("Last Name", form.REGEX_NAME, "* first letter - Capital\n* minimum 3 characters");
        }
    }
}
