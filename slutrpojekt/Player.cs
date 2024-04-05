using Raylib_cs;
using System.Numerics;

public class Player : Entities
{   
    Rectangle player = new Rectangle(1000, 1000, 50, 50);
    public Vector2 Position
    {
        get { return new Vector2(player.X, player.Y); }
    }
    public void DrawPlayer()
    {
        Raylib.DrawRectangleRec(player, Color.Black);
        
    }
    public void PlayerMovement()
    {
        if (Raylib.IsKeyDown(KeyboardKey.D))
            player.X += speed;
        if (Raylib.IsKeyDown(KeyboardKey.A))
            player.X -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.W))
            player.Y -=speed;
        if (Raylib.IsKeyDown(KeyboardKey.S))
            player.Y +=speed;
    }
}
