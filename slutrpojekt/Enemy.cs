using Raylib_cs;
using System.Numerics;

public class Enemy : Entities
{
    Rectangle enemy = new Rectangle(875, 10, 150, 150);
    public void DrawEnemy()
    {
        Raylib.DrawRectangleRec(enemy, Color.Red);

    }
    public void EnemyMovement(Player player)
    {
        Vector2 playerPosition = player.Position;
        Vector2 direction = new Vector2(playerPosition.X - enemy.X, playerPosition.Y - enemy.Y);
        direction = Vector2.Normalize(direction);

        enemy.X += direction.X * speed;
        enemy.Y += direction.Y * speed;
    }
}