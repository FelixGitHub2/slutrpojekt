using Raylib_cs;
using System.Numerics;

public class Player : Entities
{   
    Rectangle player = new Rectangle(1000, 1000, 50, 50);
    public void DrawPlayer()
    {
        Raylib.DrawRectangleRec(player, Color.Black);
        
    }
    public void PlayerMovement()
    {
        Vector2 playerPos = new Vector2(player.X, player.Y);
        if (Raylib.IsKeyDown(KeyboardKey.D))
            player.X += speed;
        if (Raylib.IsKeyDown(KeyboardKey.A))
            player.X -= speed;
    }
}
