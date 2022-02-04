using System;
using System.Collections.Generic;

namespace Game
{
    public class TerminalService
    {
        //string guessWord = "G _ _ _ _";
        char guessedLetter = '_';

        // Make an instance of Guess class.
        Guess guess = new Guess();
        
        // Display all frames.
        public void mainDisplay()
        {
            parachuteDisplay();
            //firstFrame(guess.guessWord);
            //nextFrame(guess.guessWord);

        }
        public char getGuess() {
            return guessedLetter;
        }
        
        // Choose which parachute image to display.
        private string parachuteDisplay()
        {
            
            Console.WriteLine(@"
  ___
 /___\
 \   /
  \ /
   O
  /|\
  / \");
            return parachuteDisplay();
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