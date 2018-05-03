using System;
using System.IO;

class Game
{
    // member variables
    public Surface screen;
    public static Camera c;
    // initialize
    public void Init()
    {
        c = new Camera();
    }
    // tick: renders one frame
    public void Tick()
    {
        screen.Clear(0);
    }
}