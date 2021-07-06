using System;
using System.Threading;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Values to check password validity
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "`~!@#$%^&*()-_=+[{]};:'\"|\\,<.>/?";
            int score = 0;
            
            //Program starting notification
            Console.WriteLine("Password checker has begun");
            Thread.Sleep(2000);
            Console.Clear();

            //Prompt user to enter a password
            Console.WriteLine("Please enter a password:");
            string userPassword = Console.ReadLine();

            //Checks if password is 8 characters
            if (userPassword.Length >= minLength)
            {
                score++;
            }

            //Checks if password has uppercase
            if (Tools.Contains(userPassword, uppercase))
            {
                score++;
            }

            //Checks if password has lowercase
            if (Tools.Contains( userPassword, lowercase))
            {
                score++;
            }

            //Checks if password contains a digit
            if (Tools.Contains(userPassword, digits))
            {
                score++;
            }

            //Checks if password contains a special character
            if (Tools.Contains(userPassword, specialChars))
            {
                score++;
            }

            //Checks if password is common passwords
            if (userPassword == "password" || userPassword == "1234")
            {
                score = 0;
            }


            //Prints out the password strength
             switch (score)
            {
                case 1:
                    Console.WriteLine("Password is weak.");
                    break;
                case 2:
                    Console.WriteLine("Password is medium.");
                    break;
                case 3:
                    Console.WriteLine("Password is strong");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Password is extremely strong.");
                    break;
                default:
                    Console.WriteLine("Password doesn’t meet any of the standards");
                    break;
            }

        }
    }
}