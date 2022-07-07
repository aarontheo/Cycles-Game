using System;
using Raylib_cs;

namespace Cycles_Game.Game.Grid.CellTypes
{
    public class Trail:Cell
    {
        public Trail(int x, int y, Color color,byte lifetime) : base(x,y,color)
        {
            this.life = lifetime;
        }
        public override void Update(Grid grid)
        {
            if (life == 0)
            {
                grid.SetCell(pos, null);
            }
            life--;
        }
    }
}
