using Raylib_cs;

namespace Cycles_Game.Game.Grid
{
    public abstract class Cell
    {
        public short life;
        public Color color = new Color(255, 255, 255, 255);
        public Cell(Color color)
        {
            //this.pos = new Point(x, y);
            this.color = color;
        }
        /// <summary>
        /// the default Update method does nothing except persist the Cell to the next frame.
        /// </summary>
        /// <param name="grid"></param>
        public virtual void Update(Grid grid, int x, int y)
        {
            grid.SetCell(x, y, this);
        }
        public virtual void Draw(Grid grid,int x,int y)
        {
            int size = grid.cellSize;
            Raylib.DrawRectangle(x * size, y * size, size, size, color);
        }
        /// <summary>
        /// Returns a list of the 8 cells surrounding the given cell on the given grid.
        /// The order of cells is from top left, clockwise, including corners.
        /// </summary>
        /// <returns></returns>
        public virtual Cell[] Neighbors(Grid grid,int x,int y)
        {
            //it ain't pretty, but it gets the job done
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
