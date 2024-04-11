using Raylib_cs;
using System.Diagnostics.Contracts;
using System.Numerics;

public class Player : Entities
{
    public Player()
    {
        rect = new Rectangle(1000, 1000, 50, 50);
    }
    public Vector2 Position
    {
        get { return new Vector2(rect.X, rect.Y); }
    }
    public void DrawPlayer()
    {
        Raylib.DrawRectangleRec(rect, Color.Black);

    }
    public void PlayerMovement()
    {
        if (Raylib.IsKeyDown(KeyboardKey.D))
            rect.X += speed;
        if (Raylib.IsKeyDown(KeyboardKey.A))
            rect.X -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.W))
            rect.Y -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.S))
            rect.Y += speed;
    }
}
