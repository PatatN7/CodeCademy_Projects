using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask if users wants to ENCRYPT or DECRYPT
            Console.WriteLine("Would you like to ENCRYPT or DECRYPT?");
            string userDecision = Console.ReadLine();
            string userDecisionUp = userDecision.ToUpper();
            bool userDecisionCheck = userDecisionUp == "ENCRYPT" || userDecisionUp == "DECRYPT";

            //Checks if user entered anything else that was not asked
            while (userDecisionCheck == false)
            {
                Console.WriteLine("Please only enter ENCRYPT or DECRYPT");
                userDecision = Console.ReadLine();
                userDecisionUp = userDecision.ToUpper();
                if (userDecisionUp == "ENCRYPT" || userDecisionUp == "DECRYPT")
                {
                    userDecisionCheck = true;
                }
            }

            //Asks the user for the key value
            Console.WriteLine("What is the key value?");
            string userKey = Console.ReadLine();
            bool userKeyCheck = Int32.TryParse(userKey, out int keyResult);

            //Checks if user entered not a number for key value
            while (userKeyCheck == false)
            {
                Console.WriteLine("Please only enter a number for the key value.");
                userKey = Console.ReadLine();
                userKeyCheck = Int32.TryParse(userKey, out keyResult);
            }

            //If key value is negative out of Index will occur in methods
            int key = Math.Abs(keyResult);

            //Outputs the encrypted or decrypted message
            if (userDecisionUp == "ENCRYPT")
            {
                Console.WriteLine("Please type out your message you want to encrypt:");
                string secretMsgInput = Console.ReadLine();
                Encrypt(secretMsgInput, key);
            }
            else
            {
                Console.WriteLine("Please type out your message you want to decrypt:");
                string secretMsgInput = Console.ReadLine();
                Decrypt(secretMsgInput, key);
            }

        }

        //Method to encrypt message
        static void Encrypt(string secretMsgInput, int key)
        {
            //Array used to check position of letter in alphabet
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //Changes user's message from string to a char array
            string secretMsg = secretMsgInput.ToLower();
            char[] secretMessage = secretMsg.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            //Checks each char position of user's message in alphabet and incriments with key value then stores new char in encryptedMessage array
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char secretChar = secretMessage[i];
                if (Array.IndexOf(alphabet, secretChar) != -1)
                {
                    int encryptedChar = ((Array.IndexOf(alphabet, secretChar) + key) % alphabet.Length);
                    char encryptedCharNew = alphabet[encryptedChar];
                    encryptedMessage.SetValue(encryptedCharNew, i);
                }
                else encryptedMessage.SetValue(secretChar, i);
            }

            //Joins the char array encryptedMessage back to string and outputs the encrypted message
            string superSecretMessage = String.Join("", encryptedMessage);
            Console.WriteLine();
            Console.WriteLine("Your ecrypted message is:");
            Console.WriteLine();
            Console.WriteLine(superSecretMessage);
        }

        //Method to decrypt message
        static void Decrypt(string secretMsgInput, int key)
        {
            //Array used to check position of letter in alphabet
            char[] alphabet = new char[] { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a' };

            //Changes user's encrypted message from string to a char array
            string secretMsg = secretMsgInput.ToLower();
            char[] secretMessage = secretMsg.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            //Checks each char position of user's encrypted message in alphabet and incriments with key value then stores new char in encryptedMessage array
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char secretChar = secretMessage[i];
                if (Array.IndexOf(alphabet, secretChar) != -1)
                {
                    int encryptedChar = ((Array.IndexOf(alphabet, secretChar) + key) % 26);
                    char encryptedCharNew = alphabet[encryptedChar];
                    encryptedMessage.SetValue(encryptedCharNew, i);
                }
                else encryptedMessage.SetValue(secretChar, i);
            }

            //Joins the char array encryptedMessage back to string and outputs the decrypted message
            string superSecretMessage = String.Join("", encryptedMessage);
            Console.WriteLine();
            Console.WriteLine("Your derypted message is:");
            Console.WriteLine();
            Console.WriteLine(superSecretMessage);
        }

    }
}