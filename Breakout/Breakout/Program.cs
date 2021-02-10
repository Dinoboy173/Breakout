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
        Ball ball;
        Tile[] tile;
        Tile tiles;

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
                DoPlayerBallCollision();
            }

            Raylib.CloseWindow();
        }

        void LoadGame()
        {
            player = new Player(
                this,
                new Vector2(windowWidth / 2, windowHeight),
                new Vector2(250, 50));

            ball = new Ball(
                this,
                new Vector2(windowWidth / 2, windowHeight - 50),
                new Vector2(10, 10),
                new Vector2(0.707f, 0.707f));

            for (int i = 0; i < tile.Length; i++)
            {
                for (int ii = 0;  ii <= (tile.Length / 5); ii++)
                {
                    tiles = new Tile(
                        this,
                        new Vector2(windowWidth / 8, windowHeight / 4),
                        new Vector2(windowWidth / 8, 20));
                }
            }
        }

        void Update()
        {
            player.Update();
            ball.Update();
        }

        void DoPlayerBallCollision()
        {
            float top = player.pos.Y - player.size.Y / 2;
            float bottom = player.pos.Y + player.size.Y / 2;
            float right = player.pos.X + player.size.X / 2;
            float left = player.pos.X - player.size.X / 2;

            if (ball.pos.Y > top && ball.pos.Y < bottom && ball.pos.X > left && ball.pos.X < right)
            {
                ball.dir.Y = -ball.dir.Y;
            }
        }

        void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DARKGRAY);

            player.Draw();
            ball.Draw();



            Raylib.EndDrawing();
        }
    }
}
