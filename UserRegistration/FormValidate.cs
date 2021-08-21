using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class FormValidate
    {
        // Patterns
        public string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}";
        public string REGEX_EMAIL = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+\.?[A-Za-z]+\.?[A-Za-z]{2,}$";


        // Default form validator
        public void Form(string field, string REGEX, string message)
        {
            bool flag = false;

            while (!flag)
            {
                Console.Write($"\nEnter the {field}: ");
                string field_value = Console.ReadLine();
    
                flag = (Regex.IsMatch(field_value, REGEX));
                if (flag == false)
                {
                    Console.WriteLine(message + "\n");
                }
            }
        }
    }
}