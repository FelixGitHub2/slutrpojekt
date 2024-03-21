using Raylib_cs;
using System.Numerics;
using Game;


Raylib.SetTargetFPS(60);
Raylib.InitWindow(1920, 1080, "Slutprojekt");
Raylib.ToggleFullscreen();

Player player = new Player();

Enemy enemy = new Enemy();

while (!Raylib.WindowShouldClose())
{

    player.Draw();

    player.Movement();

    Raylib.ClearBackground(Color.SkyBlue);

    Raylib.EndDrawing();
}