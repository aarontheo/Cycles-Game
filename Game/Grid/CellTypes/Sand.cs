using System;
using Raylib_cs;

namespace Cycles_Game.Game.Grid.CellTypes
{
    public class Sand : Cell
    {
        public Sand(int x, int y) : base(Color.BEIGE)
        {
            
        }
        public override void Update(Grid grid,int x,int y)
        {
            base.Update(grid,x,y);

        }
    }
}
