using System;
using Raylib_cs;
using Cycles_Game.Game.Grid;

namespace Cycles_Game.Game
{
    public class InputService
    {
        private KeyboardKey left;
        private KeyboardKey right;
        public InputService(KeyboardKey left,KeyboardKey right)
        {
            this.left = left;
            this.right = right;
        }
        public int GetLR()
        {
            int dir = 0;
            if (Raylib.IsKeyDown(left))
            {
                dir--;
            }
            if (Raylib.IsKeyDown(right))
            {
                dir++;
            }
            return dir;
        }
        public Point GetDirection()
        {
            int dx = 0;
            int dy = 0;
            if (Raylib.IsKeyDown(left))
            {
                dx -= 1;
            }
            if (Raylib.IsKeyDown(right))
            {
                dx += 1;
            }
            //re-enable this to allow up and down motion
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                dy -= 1;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                dy += 1;
            }
            return new Point(dx, dy);
        }
    }
}
