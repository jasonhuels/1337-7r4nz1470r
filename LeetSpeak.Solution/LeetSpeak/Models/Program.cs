using System;
using LeetSpeak;

class Program
    {
        static void Main()
        {
            string InputString;
            
            Console.WriteLine("Enter a word to translate into 1337 speak:\n-----------------------------------");
            InputString = Console.ReadLine();
            Translator leet = new Translator();
            

            Console.WriteLine(leet.EnglishToLeet(InputString) + "\n\n");


            if (InputString != "exit")
            {
                Main();
            } 
            
        }

        
    }