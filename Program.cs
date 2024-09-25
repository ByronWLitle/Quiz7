using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int selection = 0;
            do
            {
                Console.WriteLine("String Manipulation Program"); //Title of program
                Console.WriteLine(); //Space provided for better visibility
                Console.WriteLine("What operation would you like to perform?"); //Prompts user on which operation to use
                Console.WriteLine("1. Reverse String");
                Console.WriteLine("2. Count Vowels");
                Console.WriteLine("3. Palindrome Check");
                Console.WriteLine("4. Exit Program");
                selection = Convert.ToInt32(Console.ReadLine()); //Converts user input to int variable called selection
                switch (selection) //Uses selection variable to go into specified case structure prompted above
                {
                    case 1:
                        Console.WriteLine("Write a string:"); //Prompts user for string
                        userInput = Console.ReadLine(); //Takes user input to convert to string variable userInput
                        ReverseString(userInput); //Calls method ReverseString to take userInput and output the reverse
                        break;
                    case 2:
                        Console.WriteLine("Write a string:"); //Prompts user for string
                        userInput = Console.ReadLine(); //Takes user input to convert to string variable userInput
                        CountVowels(userInput); //Calls method CountVowels to take userInput and output number of vowels in string
                        break;
                    case 3:
                        Console.WriteLine("Write a string:"); //Prompts user for string
                        userInput = Console.ReadLine(); //Takes user input to convert to string variable userInput
                        IsPalindrome(userInput); //Calls method IsPalidrome to check userInput and output if string is palindrome or not
                        break;
                    case 4: //Case 4 is when user wants to leave program
                        break;
                }
            } while (selection != 4);
            Console.WriteLine("Program completed"); //Outputs to user that program is finished
            Console.ReadLine(); //Pauses program to allow user to view
        }
        public static string ReverseString(string input)
        {
            input.Reverse();
            return input;
        }
        public static void CountVowels(string input)
        {
            input = input.ToLower();
            int vowels = 0;
            switch(input)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    vowels++;
                    break;
            }
            Console.WriteLine($"There are a total of {vowels} vowels.");
        }
        public static void IsPalindrome(string input)
        {
            bool Palindrome = false;

            for (int i = 0; i <= input.Length / 2; i++)
            {
                //if (input[i] = input[input.Length - i])
                {
                    Palindrome = true;
                }
            }

            if (Palindrome)
            {
                Console.WriteLine($"{input} IS a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a palindrome");
            }
        }
    }
}
