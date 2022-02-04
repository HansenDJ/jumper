using System;
using System.Collections.Generic;

namespace Game
{

    public class Director
    {
        TerminalService terminalService = new TerminalService ();
        public static bool playingNow = true;
        public void StartGame()
        {
            /* Example Get Word
            Guess guess = new Guess();
            string word = guess.getWord();
            Console.WriteLine(word);
            Console.WriteLine(guess.getHashedWord());
            */
            
            while (playingNow) // Call methods and functions from here, infinite loop until PlayNow is false;
            {
              terminalService.mainDisplay();
            }

        }

    }
}