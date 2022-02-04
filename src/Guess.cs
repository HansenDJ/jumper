using System;
using System.Collections.Generic;

namespace Game;
class Guess
{   
    List<char> wordHashed = new List<char>();
    string wordComplete = "";

    public string getHashedWord() {
        string hashedWord = "";
        for(int i = 0; i < wordHashed.ToArray().Length;i++) {
            hashedWord += wordHashed.ElementAt(i);
        }
        return hashedWord;
    }
    public void letterCheck(char inputLetter) {
         for(int i = 0; i < wordHashed.ToArray().Length;i++) {
            if(inputLetter == wordComplete[i]) {
                wordHashed[i] = inputLetter;
            }
        }

    }
    
        private string generateWord() {
      string line = File.ReadLines("wordList.txt").ElementAt(randomNumber());
        return line;
    }
    private int randomNumber() {
        Random random = new Random();

        return random.Next(1,1000);

    }
    private void generateHash(int wordLength) {
        wordHashed.Clear();
        for(int i = 0; i < wordLength; i++) {
            wordHashed.Add('_');
        }
    }
    
    public string getWord(){
        bool conditionmet = false;
        string currentWord = "";
        while(conditionmet == false){
        currentWord = generateWord();
        int length = currentWord.Length;
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

    