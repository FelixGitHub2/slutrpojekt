using Raylib_cs;
using System.Numerics;

//ARV
public class Enemy : Entities
{
    //ENEMY CONSTRUCTOR
    public Enemy()
    {
        rect = new Rectangle(875, 10, 150, 150);
    }
    public void DrawEnemy()
    {
        Raylib.DrawRectangleRec(rect, Color.Red);

    }
    //ENEMY MOVEMENT ALGORITHM, GETS PLAYER POS, CALCULATES ENEMY TO PLAYER DISTANCE, NORMALISES DIRECTION TO MOVE AT CONSTANT SPEED, ENEMY SPEED
    public void EnemyMovement(Player player)
    {
        Vector2 playerPosition = player.Position;
        Vector2 direction = new Vector2(playerPosition.X - rect.X, playerPosition.Y - rect.Y);
        direction = Vector2.Normalize(direction);

        rect.X += direction.X * speed;
        rect.Y += direction.Y * speed;
    }
}