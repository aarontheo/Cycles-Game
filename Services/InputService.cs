using System;
using Raylib_cs;
using Cycles_Game.Game;
using Cycles_Game.Game.Casting;

namespace Cycles_Game.Services
{
    public class InputService
    {
        private Point p = new Point(1,1);
        //the keys array has the 4 directional keys, in order WASD, or up/left/down/right
        private KeyboardKey[] keys = new KeyboardKey[4];
        public InputService(KeyboardKey left,KeyboardKey right,KeyboardKey up,KeyboardKey down)
        {
            keys[0] = up;
            keys[1] = left;
            keys[2] = down;
            keys[3] = right;
        }
        public Point GetDirection()
        {
            int dx = 0;
            int dy = 0;
            if (Raylib.IsKeyDown(keys[1]))
            {
                dx -= 1;
            }
            if (Raylib.IsKeyDown(keys[3]))
            {
                dx += 1;
            }
            //re-enable this to allow up and down motion
            if (Raylib.IsKeyDown(keys[0]))
            {
                dy -= 1;
            }
            if (Raylib.IsKeyDown(keys[2]))
            {
                dy += 1;
            }
            return new Point(dx, dy);
        }
        public Point GetDirectionEx()
        {
            int dx = 0;
            int dy = 0;
            if (Raylib.IsKeyDown(keys[1]))
            {
                dx -= 1;
                dy = 0;
            }
            if (Raylib.IsKeyDown(keys[3]))
            {
                dx += 1;
                dy = 0;
            }
            //re-enable this to allow up and down motion
            if (Raylib.IsKeyDown(keys[0]))
            {
                dy -= 1;
                dx = 0;
            }
            if (Raylib.IsKeyDown(keys[2]))
            {
                dy += 1;
                dx = 0;
            }
            return new Point(dx, dy);
        }
    }
}
