using System;
using System.Collections.Generic;

namespace Game
{
    public class TerminalService
    {
        char guessedLetter = '_';

        // Display all frames.
        /* public void mainDisplay()
        {
            parachuteDisplay();
            firstFrame(guess.hashedWord);
            nextFrame(guess.hashedWord);

        } */
        public char getGuess()
        {
            return guessedLetter;
        }

        // Choose which parachute image to display.
        private string parachuteDisplay()
        {
            // Create an instance of the Jumper class.
            Jumper jumper = new Jumper();
            
            string parachuteString = "";

            switch(jumper.mistakes)
            {
                case 0:
                    parachuteString = (@"
   x
  /|\
  / \");
                    break;
                case 1:
                    parachuteString = (@"
  \ /
   O
  /|\
  / \");
                    break;
                case 2:
                    parachuteString = (@"
 \   /
  \ /
   O
  /|\
  / \");
                    break;
                case 3:
                    parachuteString = (@"
 /   \
 \   /
  \ /
   O
  /|\
  / \");
                    break;
                case 4:
                    parachuteString = (@"
 /___\
 \   /
  \ /
   O
  /|\
  / \");
                    break;
                case 5:
                    parachuteString = (@"
  ___
 /___\
 \   /
  \ /
   O
  /|\
  / \");
                    break;
                
            }
            return parachuteString;
        }

        // Display initial frame.
        public void firstFrame(string hashedWord)
        {
            Console.WriteLine($@"       
{hashedWord}

{parachuteDisplay()}

^^^^^^^
");
        }

        // Displays graphics for one turn.
        public void nextFrame(string hashedWord) // Parameter hashedWord is the string of the correct letters and underscores. 
        {
            char ch;
            bool isTypeChar;
            
            Console.WriteLine("Guess a letter [a-z]: ");

            // Set to true if input is a single character.
            // Set to false if input is any other data type.
            isTypeChar = Char.TryParse(Console.ReadLine(), out ch);
            if (isTypeChar == true)
            {
                Console.WriteLine($@"
{hashedWord}

{parachuteDisplay()}

^^^^^^^
");
            }
        }
    }
}