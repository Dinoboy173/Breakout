using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Breakout
{
    class Ball
    {
        Program program;

        public Vector2 pos = new Vector2();
        public Vector2 dir = new Vector2();
        public Vector2 size = new Vector2();
        public int radius = 20;
        public float speed = 5.0f;

        public Ball(Program program, Vector2 pos, Vector2 size, Vector2 dir)
        {
            this.program = program;
            this.pos = pos;
            this.size = size;
            this.dir = dir;
        }

        public void Update()
        {
            pos += dir * speed;

            if (pos.Y < 0 || pos.Y > program.windowHeight) dir.Y = -dir.Y;
            if (pos.X < 0 || pos.X > program.windowWidth) dir.X = -dir.X;
        }

        public void Draw()
        {
            Raylib.DrawCircle((int)pos.X, (int)pos.Y, radius, Color.RED);
        }
    }
}
