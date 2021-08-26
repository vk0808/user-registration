using System;

namespace UserRegistration
{
    class Program
    {
        static void InitiateForm() 
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
            form.Form("Password", form.REGEX_PASSWORD, "* minimum 8 characters\n* atleast 1 Upper Case\n* atleast 1 number\n* exactly 1 special character");


            // Validate sample email ids
            Console.WriteLine("\n\nSample email id validation\n------------------------\n");
            string[] emailIds = {
                "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net",
                "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc","abc@.com.my",
                "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com",
                "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a",
                "abc@gmail.com.aa.au"
            };

            foreach (var email in emailIds)
            {
                form.EmailValidator(email, form.REGEX_EMAIL);
            }
        }
        static void Main(string[] args)
        {
            UserReflection.ReflectionTest();
        }
    }
}
