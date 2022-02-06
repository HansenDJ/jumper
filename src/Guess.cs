using System;
using System.Collections.Generic;

namespace Game;

internal class Guess
{
    private List<char> wordHashed = new();
    public string wordComplete = "";
    public static bool GuessedWord = false;

    public string getHashedWord()
    {
        var hashedWord = "";
        for (var i = 0; i < wordHashed.ToArray().Length; i++) hashedWord += wordHashed.ElementAt(i);
        return hashedWord;
    }

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

    private string generateWord()
    {
        var line = File.ReadLines("wordList.txt").ElementAt(randomNumber());
        return line;
    }

    private int randomNumber()
    {
        var random = new Random();

        return random.Next(1, 1000);
    }

    private void generateHash(int wordLength)
    {
        wordHashed.Clear();
        for (var i = 0; i < wordLength; i++) wordHashed.Add('_');
    }

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


// list of words txt words 
// random number created 
// grab the word on that line
// block out 3 three of the letters in the word 
// 