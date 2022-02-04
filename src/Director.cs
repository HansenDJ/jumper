using System;
using System.Collections.Generic;

namespace Game
{

    public class Director
    {
        
        public static bool playingNow = true;
        public void StartGame()
        {
            // Create instance of TerminalService class
            TerminalService terminalService = new TerminalService ();
            /* Example Get Word
            
            string word = guess.getWord();
            Console.WriteLine(word);
            Console.WriteLine(guess.getHashedWord());
            */
            Guess guess = new Guess();
            guess.getWord();
            while (playingNow) // Call methods and functions from here, infinite loop until PlayNow is false;
            {
              
                // terminalService.mainDisplay();
              
            }

        }


    }
}