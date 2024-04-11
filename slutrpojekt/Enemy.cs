using Raylib_cs;
using System.Numerics;

public class Enemy : Entities
{
    public Enemy()
    {
        rect = new Rectangle(875, 10, 150, 150);
    }
    public void DrawEnemy()
    {
        Raylib.DrawRectangleRec(rect, Color.Red);

    }
    public void EnemyMovement(Player player)
    {
        Vector2 playerPosition = player.Position;
        Vector2 direction = new Vector2(playerPosition.X - rect.X, playerPosition.Y - rect.Y);
        direction = Vector2.Normalize(direction);

        rect.X += direction.X * speed;
        rect.Y += direction.Y * speed;
    }
}