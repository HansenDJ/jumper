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

            string parachuteString = (@"
  ___
 /___\
 \   /
  \ /
   O
  /|\
  / \");
            return parachuteString;
        }

        // Display initial frame.
        private void firstFrame(string guessWord)
        {
            Console.WriteLine($@"{guessWord}
{parachuteDisplay()}
^^^^^^^
");
        }

        // Displays graphics for one turn.
        public void nextFrame(string guessWord) // Parameters: 
        {
            Console.WriteLine("Guess a letter [a-z]: ");
            Console.ReadLine();
            Console.WriteLine($@"{guessWord}
{parachuteDisplay()}
^^^^^^^
");

        }
    }
}
//