using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace UserRegistration
{
    public class UserReflection
    {
        public static void ReflectionTest()
        {
            Type type = typeof(FormValidate);

            // Display fully ClassName and ClassName
            Console.WriteLine("Class and it's full name\n");
            Console.WriteLine($"{"Class Name: ", 15} {type.Name}");
            Console.WriteLine($"{"Full Name: ", 15} {type.FullName}");
            Console.WriteLine("-------------------------------------\n");


            // Get methods
            Console.WriteLine("\nMethods in FormValidate Class\n");
            MethodInfo[] methods = type.GetMethods();

            // Display methods
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"Method Name: {method.Name,20}\tReturn type: {method.ReturnType.Name, 10}");
            }
            Console.WriteLine("-------------------------------------\n");


            // Get properties
            Console.WriteLine("Properties in FormValidate Class\n");
            PropertyInfo[] propertyInfo = type.GetProperties();
            
            // Display properties
            foreach (PropertyInfo property in propertyInfo)
            {
                Console.WriteLine($"Property Name: {property.Name,20}\tProperty type: {property.PropertyType.Name,10}");
            }
            Console.WriteLine("-------------------------------------\n");


            // Get constructors
            Console.WriteLine("Constructors in FormValidate Class\n");
            ConstructorInfo[] constructors = type.GetConstructors();
            
            // Display constructors
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
