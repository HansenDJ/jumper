using System;

namespace Game;
class Guess
{   
    public string generateWord() {
      string line = File.ReadLines("wordList.txt").ElementAt(randomNumber());
        return line;
    }
    private int randomNumber() {
        Random random = new Random();

        return random.Next(1,1000);
    }
}