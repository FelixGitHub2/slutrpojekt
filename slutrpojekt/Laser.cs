using Raylib_cs;
using System.Numerics;

public class Laser
{
    //variables
    int x;
    int y;
    int speed;

    public Laser(int playerPosX, int PlayerPosY)
    {
        x = playerPosX;
        y = PlayerPosY;

        speed = 10;
    }
}