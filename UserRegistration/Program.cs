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

            
            form.Form("First Name", form.REGEX_NAME);
        }
    }
}
