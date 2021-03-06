using System;
using System.Collections.Generic;

namespace Game;

public class TerminalService
{
    private char guessedLetter = '_';

    // Method to be called in the Director to update the guessedLetter variable.
    public char getGuess()
    {
        return guessedLetter;
    }

    // Choose which parachute image to display.
    private string parachuteDisplay()
    {
        var parachuteString = "";

        switch (Jumper.mistakes)
        {
            case 0:
                parachuteString = @"
   x
  /|\
  / \
You Died, type any letter to play again";


                break;
            case 1:
                parachuteString = @"
  \ /
   O
  /|\
  / \";
                break;
            case 2:
                parachuteString = @"
 \   /
  \ /
   O
  /|\
  / \";
                break;
            case 3:
                parachuteString = @"
 /   \
 \   /
  \ /
   O
  /|\
  / \";
                break;
            case 4:
                parachuteString = @"
 /___\
 \   /
  \ /
   O
  /|\
  / \";
                break;
            case 5:
                parachuteString = @"
  ___
 /___\
 \   /
  \ /
   O
  /|\
  / \";
                break;
        }

        return parachuteString;
    }

    public void died(string word)
    {
        Console.WriteLine("The word was: " + word);
    }

    // Displays that you won the game if your guessed the word correctly.
    public void victoryFrame()
    {
        Console.WriteLine("You Win! type any letter to play again");

        var readChar = Console.ReadKey().KeyChar;
        Director.restart = true;
    }

    // Displays graphics each guess.
    public void nextFrame(string hashedWord) // Parameter hashedWord is the string of the correct letters and underscores. 
    {
        if (Guess.GuessedWord)
        {
            victoryFrame();
        }
        else if (Jumper.mistakes > 0)
        {
           
            Console.WriteLine($@"
{hashedWord}

{parachuteDisplay()}

^^^^^^^
");

            Console.WriteLine("Guess a letter [a-z]: ");
            var readChar = Console.ReadKey().KeyChar;
            guessedLetter = readChar;
            Console.Clear();
        }
        else
        {
            Console.WriteLine(parachuteDisplay());
            var readChar = Console.ReadKey().KeyChar;
            Console.Clear();
            Director.restart = true;
        }
    }
}