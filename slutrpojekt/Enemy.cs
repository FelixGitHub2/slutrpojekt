using Raylib_cs;
using System.Numerics;

public class Enemy : Entities
{
    Rectangle enemy = new Rectangle(875, 10, 150, 150);
    public void DrawEnemy()
    {
        Raylib.DrawRectangleRec(enemy, Color.Red);

    }
    public void EnemyMovement()
    {

    }
}