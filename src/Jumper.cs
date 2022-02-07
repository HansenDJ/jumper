// The Jumper class will keep track of how many mistakes the player has before the jumper dies and they recive Game Over!

namespace Game;

internal class Jumper
{
    public static int mistakes = 5;

    public void decreaseMistakeCount() // when a player misses a word
    {
        mistakes--;
    }

    public static void resetLife() // when a game is restart the life is reset
    {
        mistakes = 5;
    }
}