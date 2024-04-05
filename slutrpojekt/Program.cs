using Raylib_cs;
using System.Numerics;


Raylib.SetTargetFPS(60);
Raylib.InitWindow(1920, 1080, "Slutprojekt");
Raylib.ToggleFullscreen();

Entities entities = new Entities();

Player player = new Player();
player.speed = 10;
player.hp = 3;

Enemy enemy = new Enemy();
enemy.speed = 1;

while (!Raylib.WindowShouldClose())
{

    enemy.DrawEnemy();

    player.DrawPlayer();

    player.PlayerMovement();

    enemy.EnemyMovement(player);



    Raylib.ClearBackground(Color.SkyBlue);

    Raylib.EndDrawing();
}