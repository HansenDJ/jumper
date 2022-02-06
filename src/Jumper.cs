// The Jumper class will keep track of how many mistakes the player has before the jumper dies and they recive Game Over!

namespace Game;

internal class Jumper
{
    public static int mistakes = 5;

    public void decreeseMistakeCount()
    {
        mistakes--;
    }

    public static void resetLife()
    {
        mistakes = 5;
    }
}