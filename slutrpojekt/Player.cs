using Raylib_cs;
using System.Diagnostics.Contracts;
using System.Numerics;

public class Player : Entities
{
    //PLAYER CONSTRUCTOR
    public Player()
    {
        rect = new Rectangle(1000, 800, 50, 50);
    }
    //PLAYER POSITION LOGIC, WHENEVER "Position" IS ACCESED SEND PLAYER POSITION
    public Vector2 Position
    {
        get { return new Vector2(rect.X, rect.Y); }
    }
    //PLAYER DRAW METHOD TO DRAW OUT THE PLAYER WITH RAYLIBS DRAW SYSTEM
    public void DrawPlayer()
    {
        Raylib.DrawRectangleRec(rect, Color.Black);

    }
    //PLAYER MOVEMENT CODE NO NORMALIZE FOR BETTER SPEED AGAINST ENEMY
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
