using System;

namespace ABC
{
    class SelectionStatement
    {
        public void LearnIfElse()
        {
            Console.Write("Enter your age: ");
            string ageString = Console.ReadLine();
            byte age = byte.Parse(ageString);

            if (age > 60)
            {
                Console.WriteLine("You are eligible for pension.");
            }
            else if (age > 50)
            {
                Console.WriteLine("You are about to be eligible for pension.");
            }
            else
            {
                Console.WriteLine("You are not eligible for pension.");
            }
        }

        public void LearnSwitchCases()
        {
            Console.Write("Enter your hobby: ");
            string hobby = Console.ReadLine();

            switch (hobby)
            {
                case "books":
                    Console.WriteLine("You are very good acamedician.");
                    break;

                case "badminton":
                    Console.WriteLine("Good for your health.");
                    break;

                case "swimming":
                    Console.WriteLine("Good for your health.");
                    break;

                case "driving":
                    Console.WriteLine("That's good but be careful.");
                    break;

                default:
                    Console.WriteLine("That's interesting. Nevar heard of that.");
                    break;
            }
        }
    }
}