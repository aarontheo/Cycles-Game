using Raylib_cs;

using Cycles_Game.Game.Casting;
namespace Cycles_Game.Game.Grid
{
    public abstract class Cell
    {
        public byte life;
        public Color color = new Color(255, 255, 255, 255);
        protected Point pos;
        public Cell(int x, int y,Color color)
        {
            this.pos = new Point(x, y);
            this.color = color;
        }
        public virtual void Update(Grid grid)
        {
            
        }
        public virtual void Draw(Grid grid)
        {
            int size = grid.cellSize;
            Raylib.DrawRectangle(pos.x * size, pos.y * size, size, size, color);
        }
        /// <summary>
        /// Returns a list of the 8 cells surrounding the given cell on the given grid.
        /// The order of cells is from top left, clockwise, including corners.
        /// </summary>
        /// <returns></returns>
        public virtual Cell[] Neighbors(Grid grid)
        {
            //it ain't pretty, but it gets the job done
            int x = pos.x;
            int y = pos.y;
            Cell[] temp = new Cell[8];
            temp[0] = grid.GetCell(x - 1, y - 1);
            temp[1] = grid.GetCell(x, y - 1);
            temp[2] = grid.GetCell(x + 1, y - 1);
            temp[3] = grid.GetCell(x - 1, y);
            temp[4] = grid.GetCell(x + 1, y);
            temp[5] = grid.GetCell(x - 1, y + 1);
            temp[6] = grid.GetCell(x, y + 1);
            temp[7] = grid.GetCell(x + 1, y + 1);
            return temp;
        }
    }
}
