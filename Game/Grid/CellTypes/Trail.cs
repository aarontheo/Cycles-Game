using System;
using Raylib_cs;

namespace Cycles_Game.Game.Grid.CellTypes
{
    public class Trail : Cell
    {
        public Trail(Color color, byte lifetime) : base(color)
        {
            this.life = lifetime;
        }
        public override void Update(Grid grid, int x, int y)
        {
            base.Update(grid,x,y);
            if (life == 0)
            {
                grid.SetCell(x, y, null);
            }
            life--;
        }
        public override void Draw(Grid grid,int x,int y)
        {
            color.a = ((byte)(life + 50));
            base.Draw(grid,x,y);
        }
    }
}
