using Raylib_cs;
using System.Numerics;

// RAYLIB STANDARDS FPS, WINDOW SIZE, FULLSCREEN, EXIT KEY REMOVAL SO PLAYER DOES NOT ACCIDENTALY CRASH THE GAME
Raylib.SetTargetFPS(60);
Raylib.InitWindow(1920, 1080, "Slutprojekt");
Raylib.ToggleFullscreen();
Raylib.SetExitKey(0);

// NY INSTANS AV ENTITIES KLASSEN
Entities entities = new Entities();

// PLAYER CLASS INSTANCE AND PLAYER VARIABLE ASSIGNMENT
Player player = new Player();
player.speed = 10;
player.hp = 3;

//ENEMY INSTANCE AND ENEMY VARIABLE ASSIGNMENT
Enemy enemy = new Enemy();
enemy.speed = 8;

//CAR INSTANCE AND CAR VARIABLE ASSIGNMENT
Car car = new Car();
car.speed = 0.5f;

//LIST OF WALLS aka GENERIC CLASS
List<Rectangle> walls = new List<Rectangle>();
walls.Add(new Rectangle(0, 0, 1920, 50));
walls.Add(new Rectangle(0, 1030, 1920, 50));
walls.Add(new Rectangle(1450, 0, 500, 1500));
walls.Add(new Rectangle(0, 0, 50, 1500));

//CURRENT SCENE VARIABLE, MAKES IT SO THE GAME STARTS WITH THE menu SCENE
Scenes currentScene = Scenes.menu;

//RAYLIB LOOP
while (!Raylib.WindowShouldClose())
{
    //RAYLIB BEGIN DRAWING, DRAWS OUT EVERYTHING
    Raylib.BeginDrawing();

    //MENU SCENE, FIRST STARTING SCENE
    if (currentScene == Scenes.menu)
    {
        Raylib.DrawText("WHERE DA HOOD AT", 500, 250, 70, Color.Black);
        Raylib.DrawText("REMIXED ULTRA 5TH EDITION", 650, 310, 50, Color.Red);
        Raylib.DrawText("Press ENTER to start the game", 600, 400, 50, Color.Black);
        Raylib.ClearBackground(Color.LightGray);

        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            currentScene = Scenes.info;
        }

    }
    else if (currentScene == Scenes.info)
    {
        Raylib.ClearBackground(Color.Black);

        Raylib.DrawText("INFO", 850, 50, 100, Color.White);
        Raylib.DrawText("DONT TOUCH ANYTHING", 500, 250, 70, Color.White);
        Raylib.DrawText("RED", 1400, 250, 70, Color.Red);
        Raylib.DrawText("CAR ", 1150, 350, 70, Color.Yellow);
        Raylib.DrawText("SURVIVE UNTIL THE       ARRIVES", 350, 350, 70, Color.White);
        Raylib.DrawText("PRESS ENTER TO START", 500, 450, 70, Color.White);
        Raylib.DrawText("CONTROLS", 10, 800, 50, Color.White);
        Raylib.DrawText("W = UP", 10, 850, 50, Color.White);
        Raylib.DrawText("S = DOWN", 10, 900, 50, Color.White);
        Raylib.DrawText("A = LEFT", 10, 950, 50, Color.White);
        Raylib.DrawText("D = RIGHT", 10, 1000, 50, Color.White);

        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            currentScene = Scenes.game;
        }
    }
    if (currentScene == Scenes.game)
    {
        enemy.DrawEnemy();

        player.DrawPlayer();

        //PLAYER MOVEMENT
        player.PlayerMovement();

        //ENEMY MOVEMENT WITH PLAYER ARGUMENT TO PROVIDE PLAYER CLASS MOVEMENT VALUES
        enemy.EnemyMovement(player);

        car.CarMovement();

        foreach (Rectangle wall in walls)
        {
            Raylib.DrawRectangleRec(wall, Color.Red);
        }

        car.DrawCar();

        Raylib.ClearBackground(Color.SkyBlue);

        Collision();
    }
    if (currentScene == Scenes.win)
    {
        Raylib.DrawText("YOU WIN :D", 500, 250, 70, Color.Green);
        Raylib.DrawText("PRESS esc TO QUIT", 250, 500, 70, Color.White);

        Raylib.ClearBackground(Color.Black);
        Raylib.SetExitKey(KeyboardKey.Escape);
    }

    if (currentScene == Scenes.lose)
    {
        Raylib.DrawText("GAME OVER", 750, 250, 70, Color.White);
        Raylib.DrawText("YOU SHOULD NOT HAVE TOUCHED RED", 250, 400, 70, Color.Red);
        Raylib.DrawText("PRESS esc TO QUIT", 600, 700, 70, Color.White);

        Raylib.ClearBackground(Color.Black);
        Raylib.SetExitKey(KeyboardKey.Escape);
    }

    Raylib.EndDrawing();
}

// COLLISION LOGIC
void Collision()
{
    if (Raylib.CheckCollisionRecs(player.rect, enemy.rect))
    {
        currentScene = Scenes.lose;
    }

    if (Raylib.CheckCollisionRecs(player.rect, car.rect))
    {
        currentScene = Scenes.win;
    }

    foreach (Rectangle wall in walls)
    {
        if (Raylib.CheckCollisionRecs(player.rect, wall))
        {
            currentScene = Scenes.lose;
        }
    }
}
// ENUMERATION LOGIC FOR SCENES, 5 CONSTANTS
public enum Scenes
{
    menu, info, game, lose, win
}

