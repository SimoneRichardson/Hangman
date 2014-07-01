using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        Random rnd = new Random();
        int response = rnd.Next(1, 4);

      

        //whenever numbers and words will remain constant in a program you can put them under class program
        word 1: 
        RandomWord = "Market";
        break;

        word 2:
        RandomWord = "House";
        break;

        word 3:
        RandomWord = "Cars";

        word 4"
        RandomWord = "Paint";

        return response;


        static void Main(string[] args)
        {
        string value = "Robot";
        int userInput = 0;
        string inData = "";
        char myletter = 'd';
        bool letterinWord = false;

            Console.WriteLine("Welcoome to Hangman");
            GameFunction();
            Console.WriteLine("Would you like to play again");
            string answer = Console.ReadLine();
            if(letter == "yes" || letter == "y")
            {
            GameFunction();
            }
            else Console.WriteLine("Game over now");
        }
        static void GameFunction();
    {
        Console.WriteLine("Guess a letter.");

        Random randomLetterGenerator = new Random();
        int randomLetter = randomLetteGenerator.Next(1,4); // Not sure if it should be letter or word?

            Console.WrteLine("Type in your guess, :");
            int intInput = 0;
            while (intInput != randomLetter)
    {
        string newInput = Console.ReadLine();
        intInput = int.Parse(newInput);
        if (intInput > randomletter)
    {   
        Console.WriteLine("no,not" +newInput);

    }

        }
    }
}
