using Raylib_cs;
using Cycles_Game.Game.Casting;
namespace Cycles_Game.Game.Grid
{
    /// <summary>
    /// A Grid is a collection of objects stored in a 2d array 
    /// </summary>
    public class Grid
    {
        public int width { get; }
        public int height { get; }
        private Cell[,] cells;
        public int cellSize { get; }
        public Grid(int width, int height, int cellSize)
        {
            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
            cells = new Cell[width, height];
        }
        public void Update()
        {
            foreach (Cell cell in cells)
            {
                if (cell != null)
                {
                    cell.Update(this);
                    cell.Draw(this);
                }
            }
        }
        public Cell GetCell(int x, int y)
        {
            return cells[x % width, y % height];
        }
        public void SetCell(int x, int y, Cell newCell)
        {
            cells[x % width, y % height] = newCell;
        }
        public void SetCell(Point pos, Cell newCell)
        {
            SetCell(pos.x, pos.y, newCell);
        }
    }
}