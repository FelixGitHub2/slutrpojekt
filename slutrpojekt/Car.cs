using Raylib_cs;
using System.Diagnostics.Contracts;
using System.Numerics;

public class Car : Entities
{
    //CAR CONSTRUCTOR
    public Car()
    {
        rect = new Rectangle(1920, 600, 50, 50);
    }

    public void DrawCar()
    {
        Raylib.DrawRectangleRec(rect, Color.Yellow);
    }

    //CAR MOVEMENT, MOVES BY ITSELF
    public void CarMovement()
    {
        Vector2 playerPos = new Vector2(rect.X, rect.Y);
        rect.X -= speed;
    }


}
