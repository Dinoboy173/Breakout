using System;
using Raylib_cs;
using System.Numerics;

namespace Breakout
{
    class Program
    {
        public int windowWidth = 900;
        public int windowHeight = 900;
        public string windowTitle = "Breakout";

        Player player;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.RunGame();
        }

        void RunGame()
        {
            Raylib.InitWindow(windowWidth, windowHeight, windowTitle);
            Raylib.SetTargetFPS(60);

            LoadGame();

            while (!Raylib.WindowShouldClose())
            {
                Update();
                Draw();
            }

            Raylib.CloseWindow();
        }

        void LoadGame()
        {
            player = new Player(
                this,
                new Vector2(windowWidth / 2, windowHeight),
                new Vector2(250, 50));
        }

        void Update()
        {
            player.Update();
        }

        void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DARKGRAY);

            player.Draw();

            Raylib.EndDrawing();
        }
    }
}
