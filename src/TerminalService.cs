using System;
using System.Collections.Generic;

namespace Game;

public class TerminalService
{
    private char guessedLetter = '_';

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
        // Create an instance of the Jumper class

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

    public void victoryFrame()
    {
        Console.WriteLine("You Win! type any letter to play again");

        var readChar = Console.ReadKey().KeyChar;
        Director.restart = true;
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
    public void
        nextFrame(string hashedWord) // Parameter hashedWord is the string of the correct letters and underscores. 
    {
        if (Guess.GuessedWord)
        {
            victoryFrame();
        }
        else if (Jumper.mistakes > 0)
        {
            char ch;
            bool isTypeChar;
            Console.WriteLine($@"
{hashedWord}

{parachuteDisplay()}

^^^^^^^
");

            Console.WriteLine("Guess a letter [a-z]: ");


            // Set to true if input is a single character.
            // Set to false if input is any other data type.

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