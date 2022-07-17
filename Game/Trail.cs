using System;
using Raylib_cs;

namespace Cycles_Game.Game.Grid.CellTypes
{
    public class Trail : Cell
    {
        short life;
        public Trail(Color color, byte lifetime) : base(color)
        {
            this.life = lifetime;
        }
        public override void Update(Grid grid, int x, int y)
        {
            if (life == 0)
            {
                //grid.SetCell(x, y, null);
            }
            else
            {
                base.Update(grid, x, y);
            }
            life--;
        }
        public override void Draw(Grid grid, int x, int y)
        {
            color.a = ((byte)(life + 50));
            base.Draw(grid, x, y);
        }
    }
}
