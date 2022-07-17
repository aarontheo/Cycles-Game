using System;
using Raylib_cs;

namespace Cycles_Game.Game.Grid.CellTypes
{
    public class Cycle : Cell
    {
        public Point vel = new Point(0, -1);
        private KeyboardKey[] keys;
        /// <param name="keys">four directional keys, in the order WASD</param>
        public Cycle(Color color, KeyboardKey[] keys) : base(color)
        {
            this.keys = keys;
        }
    }
}
