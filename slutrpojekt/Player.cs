using Raylib_cs;
using System.Numerics;

namespace Game;

public class Player
{
    float speed = 5f;
    Rectangle player = new Rectangle(1000, 1000, 50, 50);

    public void Draw()
    {
        Raylib.DrawRectangleRec(player, Color.Black);
    }

    public void Movement()
    {
        Vector2 playerPos = new Vector2(player.X, player.Y);
        if (Raylib.IsKeyDown(KeyboardKey.D))
            player.X += speed;
        if (Raylib.IsKeyDown(KeyboardKey.A))
            player.X -= speed;
    }

}