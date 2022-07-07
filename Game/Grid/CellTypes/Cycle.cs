using System;
using Raylib_cs;
using Cycles_Game.Game.Casting;

namespace Cycles_Game.Game.Grid.CellTypes
{
    public class Cycle : Cell
    {
        public Point vel = new Point(0,-1);
        private KeyboardKey[] keys;
        /// <param name="keys">four directional keys, in the order WASD</param>
        public Cycle(int x,int y,Color color,KeyboardKey[] keys) : base(x,y,color)
        {
            this.keys = keys;
        }
        public override void Update(Grid grid)
        {
            Point temp;
            //UP
            if (Raylib.IsKeyDown(keys[0]))
            {
                temp = new Point(0, -1);
                //do nothing if the new velocity is equal to the negative of the old one
                if (temp*-1 != vel)
                {
                    vel = temp;
                }
            }
            //LEFT
            if (Raylib.IsKeyDown(keys[1]))
            {
                temp = new Point(-1, 0);
                if (temp*-1 != vel)
                {
                    vel = temp;
                }
            }
            //DOWN
            if (Raylib.IsKeyDown(keys[2]))
            {
                temp = new Point(0, 1);
                if (temp*-1 != vel)
                {
                    vel = temp;
                }
            }
            //RIGHT
            if (Raylib.IsKeyDown(keys[3]))
            {
                temp = new Point(1, 0);
                if (temp*-1 != vel)
                {
                    vel = temp;
                }
            }
            grid.SetCell(pos, new Trail(pos.x,pos.y,Color.DARKBLUE,10));
            pos += vel;
            grid.SetCell(pos, this);
        }
    }
}
