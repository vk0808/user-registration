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


        // Default form validator
        public void Form(string field, string REGEX)
        {
            bool flag = false;
            Console.WriteLine($"Enter the {field}");

            while (!flag)
            {
                string field_value = Console.ReadLine();
                flag = (Regex.IsMatch(field_value, REGEX));
                if (flag == true)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid, type again");
                }
            }
        }
    }
}