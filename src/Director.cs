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
            
            while (playingNow) // Call methods and functions from here, infinite loop until PlayNow is false;
            {
              terminalService.mainDisplay();
            }

        }

    }
}