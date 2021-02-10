using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Breakout
{
    class Player
    {
        Program program;

        public Vector2 pos = new Vector2();
        public Vector2 size = new Vector2(250, 50);

        public int speed = 5;

        public Player(Program program, Vector2 pos, Vector2 size)
        {
            this.program = program;
            this.pos = pos;
            this.size = size;
        }

        public void Update()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                pos.X = (pos.X - speed);
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                pos.X = (pos.X + speed);

            if (pos.X < (0 + (size.X / 2))) pos.X = (0 + (size.X / 2));
            if (pos.X > (program.windowWidth - (size.X / 2))) pos.X = (program.windowWidth - (size.X / 2));
        }

        public void Draw()
        {
            Raylib.DrawRectanglePro(new Rectangle(pos.X, pos.Y, size.X, size.Y), size / 2, 0.0f, Color.BLUE);
        }
    }
}
