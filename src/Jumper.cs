// The Jumper class will keep track of how many mistakes the player has before the jumper dies and they recive Game Over!
namespace Game;
class Jumper
{
    int mistakes = 8;

    public void decreeseMistakeCount()
    {
        mistakes--;


    }

}
