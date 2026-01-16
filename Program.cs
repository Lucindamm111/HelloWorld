using System;

namespace PasswordCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // Create password
            string password = "a92301j2add";

            // Get password length
            var passwordLength = password.Length;

            //Hey lucinda , so this is something you can delete when you done with your lessoms
            var x = 5;

            // Check if password uses symbol
            var passwordCheck = 5;

            Console.WriteLine(passwordLength);


            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

        }
    }
}
