using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Breakout
{
    class Tile
    {
        Program program;

        public Vector2 pos = new Vector2();
        public Vector2 size = new Vector2();

        Color color;

        static Color[] colours = new Color[3] { Color.LIME, Color.GREEN, Color.DARKGREEN };
        static int nextColor = 0;

        public Tile(Program program, Vector2 pos, Vector2 size)
        {
            this.program = program;
            this.pos = pos;
            this.size = size;

            color = colours[nextColor];
            nextColor += 1;
            if (nextColor >= colours.Length)
                nextColor = 0;
        }

        public void Update()
        {

        }

        public void Draw()
        {
            Raylib.DrawRectanglePro(new Rectangle(pos.X, pos.Y, (size.X - 1), (size.Y- 1)), size / 2, 0.0f, color);
            Raylib.DrawRectanglePro(new Rectangle(pos.X, pos.Y, size.X, size.Y), size / 2, 0.0f, Color.WHITE);
        }
    }
}
