using System;
using System.Collections.Generic;

namespace Game;

public class Director
{
    public static bool playingNow = true;
    public static bool restart = false;

    public void StartGame()
    {
        // Create instance of TerminalService class
        var terminalService = new TerminalService();
        /* Example Get Word
        
        string word = guess.getWord();
        Console.WriteLine(word);
        Console.WriteLine(guess.getHashedWord());
        */
        var guess = new Guess();
        guess.getWord();
        var jumper = new Jumper();


        while (playingNow) // Call methods and functions from here, infinite loop until PlayNow is false;
        {
            if (restart == true)
            {
                guess.getWord();
                Jumper.resetLife();
                restart = false;
            }

            if (!Guess.GuessedWord)
            {
                if (Jumper.mistakes == 0) terminalService.died(guess.wordComplete);
                terminalService.nextFrame(guess.getHashedWord());
                if (!guess.letterCheck(terminalService.getGuess())) jumper.decreeseMistakeCount();
            }
            else
            {
                terminalService.nextFrame(guess.getHashedWord());
                Guess.GuessedWord = false;
            }


            // terminalService.mainDisplay();
        }
    }
}