using System;
using Raylib_cs;
using Cycles_Game.Game;
using Cycles_Game.Game.Casting;

namespace Cycles_Game.Services
{
    public class InputService
    {
        public KeyboardKey left;
        public KeyboardKey right;
        public InputService(KeyboardKey left,KeyboardKey right)
        {
            this.left = left;
            this.right = right;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>returns -1 for left, 1 for right, and 0 for no input.</returns>
        public int GetLR()
        {
            int res = 0;
            if (Raylib.IsKeyPressed(right))
            {
                res += 1;
            }
            if (Raylib.IsKeyPressed(left))
            {
                res += -1;
            }
            //Console.WriteLine(res);
            return res;
        }
        // public Point GetDirection()
        // {
        //     int dx = 0;
        //     int dy = 0;
        //     if (Raylib.IsKeyDown(keys[1]))
        //     {
        //         dx -= 1;
        //     }
        //     if (Raylib.IsKeyDown(keys[3]))
        //     {
        //         dx += 1;
        //     }
        //     //re-enable this to allow up and down motion
        //     if (Raylib.IsKeyDown(keys[0]))
        //     {
        //         dy -= 1;
        //     }
        //     if (Raylib.IsKeyDown(keys[2]))
        //     {
        //         dy += 1;
        //     }
        //     return new Point(dx, dy);
        // }
        // public Point GetDirectionEx()
        // {
        //     int dx = 0;
        //     int dy = 0;
        //     if (Raylib.IsKeyDown(keys[1]))
        //     {
        //         dx -= 1;
        //         dy = 0;
        //     }
        //     if (Raylib.IsKeyDown(keys[3]))
        //     {
        //         dx += 1;
        //         dy = 0;
        //     }
        //     //re-enable this to allow up and down motion
        //     if (Raylib.IsKeyDown(keys[0]))
        //     {
        //         dy -= 1;
        //         dx = 0;
        //     }
        //     if (Raylib.IsKeyDown(keys[2]))
        //     {
        //         dy += 1;
        //         dx = 0;
        //     }
        //     return new Point(dx, dy);
        // }
    }
}
