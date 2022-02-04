using System;
using System.Collections.Generic;

namespace Game
{
    public class TerminalService
    {
        // Checks if all the letters in the word have been guessed correctly.
        bool wordGuessed = false;
        
        // Display initial frame.
        private void firstFrame(string guessWord)
        {
            Console.WriteLine($@"{guessWord}

  ___
 /___\
 \   /
  \ /
   O
  /|\
  / \
^^^^^^^
");
        }
        
        // Displays graphics for one turn.
        public void nextFrame(string guessWord) // Parameters: 
        {
            Console.WriteLine("Guess a letter [a-z]: ");
            Console.ReadLine();
            Console.WriteLine($@"{guessWord}

  ___
 /___\
 \   /
  \ /
   O
  /|\
  / \
^^^^^^^
");
        }
    }
}