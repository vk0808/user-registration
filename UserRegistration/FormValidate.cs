using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class FormValidate
    {
        // Patterns
        public string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public string REGEX_EMAIL = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+\.?[A-Za-z]+\.?[A-Za-z]{2,}$";
        public string REGEX_MOBILE = "^[1-9]{1}[0-9]{1}\\s[1-9]{1}[0-9]{9}$";
        public string REGEX_PASSWORD = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8,}$";


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


        // Test form validator
        public bool FormVal(string field_value, string REGEX)
        {
            try
            {
                if (field_value.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_VALUE, "Field should not be empty");
                }
                if (Regex.IsMatch(field_value, REGEX))
                {
                    return true;
                }

                return false;
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_VALUE, "Field should not be null");

            }           
        }


        // sample email validator
        public void EmailValidator(string field_value, string REGEX)
        {
            bool flag = (Regex.IsMatch(field_value, REGEX));
            if (flag == false)
            {
                Console.WriteLine($"Invalid email {field_value}\n");
            }
            else
            {
                Console.WriteLine($"Valid email {field_value}\n");
            }
        }
    }
}