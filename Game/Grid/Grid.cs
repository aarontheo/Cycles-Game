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
        private Cell[,] current;
        private Cell[,] next;
        public int cellSize { get; }
        public Grid(int width, int height, int cellSize)
        {
            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
            current = new Cell[width, height];
            next = new Cell[width, height];
        }
        public void Update()
        {
            next = new Cell[width, height];
            foreach (Cell cell in current)
            {
                if (cell != null)
                {
                    cell.Update(this);
                    cell.Draw(this);
                }
            }
            //var temp = next;
            //next = new Cell[width, height];
            current = next;
        }
        public Cell GetCell(int x, int y)
        {
            return current[x % width, y % height];
        }
        public void AddCell(int x, int y, Cell newCell)
        {
            current[x % width, y % height] = newCell;
        }
        public void AddCell(Point pos, Cell newCell)
        {
            AddCell(pos.x, pos.y, newCell);
        }
        public void SetCell(int x, int y, Cell newCell)
        {
            next[x % width, y % height] = newCell;
        }
        public void SetCell(Point pos, Cell newCell)
        {
            SetCell(pos.x, pos.y, newCell);
        }
    }
}