using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            name = char.ToUpper(name[0]) + name.Substring(1);
            Console.WriteLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine();

            // Ask user if they want to go on adventure
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.WriteLine();
            Console.Write("Type YES or NO:  ");
            string noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();
            bool checkNoiseChoice;
            var result1 = noiseChoice == "YES" || noiseChoice == "NO" ? checkNoiseChoice = true : checkNoiseChoice = false;
            Console.WriteLine();

            // Loops while input is NOT YES or NO
            while (checkNoiseChoice == false)
            {
                Console.Write("Please only type YES or NO:  ");
                noiseChoice = Console.ReadLine();
                noiseChoice = noiseChoice.ToUpper();
                Console.WriteLine();
                if (noiseChoice == "YES" || noiseChoice == "NO")
                {
                    checkNoiseChoice = true;
                }
            }

            if (noiseChoice == "NO")
            {
                Console.WriteLine();
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine();
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.You walk towards it.\nDo you open it or knock ?");
                Console.WriteLine();
                Console.Write("Type OPEN or KNOCK:  ");
                string doorChoice = Console.ReadLine();
                doorChoice = doorChoice.ToUpper();
                bool checkDoorChoice;
                var result2 = doorChoice == "OPEN" || doorChoice == "KNOCK" ? checkDoorChoice = true : checkDoorChoice = false;
                Console.WriteLine();

                // Loops while input is NOT OPEN or KNOCK
                while (checkDoorChoice == false)
                {
                    Console.Write("Only enter OPEN or KNOCK:  ");
                    doorChoice = Console.ReadLine();
                    doorChoice = doorChoice.ToUpper();
                    Console.WriteLine();
                    if (doorChoice == "OPEN" || doorChoice == "KNOCK")
                    {
                        checkDoorChoice = true;
                    }
                }

                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says,\n\"Answer this riddle:\"\n\" Poor people have it. Rich people need it. If you eat it you die. What is it ?\"");
                    Console.WriteLine();
                    Console.Write("Type your answer:  ");
                    string riddleAnswer = Console.ReadLine();
                    riddleAnswer = riddleAnswer.ToUpper();
                    Console.WriteLine();

                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.\nTHE END.");
                    }
                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number (1-3):  ");
                    string keyChoice = Console.ReadLine();
                    bool checkKeyChoice;
                    var result3 = keyChoice == "1" || keyChoice == "2" || keyChoice == "3" ? checkKeyChoice = true : checkKeyChoice = false;
                    Console.WriteLine();

                    while (checkKeyChoice == false)
                    {
                        Console.Write("Please only enter a number from 1-3:  ");
                        keyChoice = Console.ReadLine();
                        Console.WriteLine();
                        if (keyChoice == "1" || keyChoice == "2" || keyChoice == "3")
                        {
                            checkKeyChoice = true;
                        }
                    }

                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there.\nStrange...\nTHE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.\nTHE END.");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}



