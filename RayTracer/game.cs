using OpenTK;
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
        c = new Camera(Vector3.Zero, new Vector3(0,0,1));
        c.Screen();
    }
    // tick: renders one frame
    public void Tick()
    {
        screen.Clear(0);
        for (int x = 0; x < screen.width; x++)
            for (int y = 0; y < screen.height; y++)
                c.ShootRay(new Vector2(x / screen.width, y / screen.height));
    }
}