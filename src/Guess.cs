using System;
using System.Collections.Generic;

namespace Game;

internal class Guess
{
    private List<char> wordHashed = new();
    public string wordComplete = "";
    public static bool GuessedWord = false;


// This pulles the list and makes it a string. 
    public string getHashedWord()
    {
        var hashedWord = "";
        for (var i = 0; i < wordHashed.ToArray().Length; i++) hashedWord += wordHashed.ElementAt(i);
        return hashedWord;
    }


// This will compare the hidden word to the letters and replace "_" with the letter guessed.  
    public bool letterCheck(char inputLetter)
    {
        var correctLetter = false;
        for (var i = 0; i < wordHashed.ToArray().Length; i++)
            if (inputLetter == wordComplete[i])
            {
                wordHashed[i] = inputLetter;
                correctLetter = true;
            }

        if (wordComplete == getHashedWord()) GuessedWord = true;

        return correctLetter;
    }


// This one takes the random number and pulls a random word. 
    private string generateWord()
    {
        var line = File.ReadLines("wordList.txt").ElementAt(randomNumber());
        return line;
    }

// This will create a random number. 
    private int randomNumber()
    {
        var random = new Random();

        return random.Next(1, 1000);
    }

// this once called will hash a word to ------.
    private void generateHash(int wordLength)
    {
        wordHashed.Clear();
        for (var i = 0; i < wordLength; i++) wordHashed.Add('_');
    }


// this take the random word and checks it lenght and then hashes it. 
    public string getWord()
    {
        var conditionmet = false;
        var currentWord = "";
        while (conditionmet == false)
        {
            currentWord = generateWord();
            var length = currentWord.Length;
            if (length >= 3)
            {
                conditionmet = true;
                generateHash(length);
                wordComplete = currentWord;
            }
        }

        return currentWord;
    }
}
