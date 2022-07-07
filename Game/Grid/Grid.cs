using Raylib_cs;

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
            for (int x = 0;x < width;x++)
            {
                for (int y = 0; y < height;y++)
                {
                    var cell = current[x, y];
                    if (cell != null)
                    {
                        cell.Update(this,x,y);
                    }
                }
            }
            //var temp = next;
            //next = new Cell[width, height];
            current = next;
        }
        public void Draw()
        {
            for (int x = 0;x < width;x++)
            {
                for (int y = 0; y < height;y++)
                {
                    var cell = next[x, y];
                    if (cell != null)
                    {
                        cell.Draw(this,x,y);
                    }
                }
            }
        }
        private int WrapInt(int a,int max)
        {
            return ((a % max) + max) % max;
        }
        public Cell GetCell(int x, int y)
        {
            return current[WrapInt(x,width), WrapInt(y,height)];
        }
        public Cell GetCell(Point pos)
        {
            return GetCell(pos.x, pos.y);
        }
        public void AddCell(int x,int y,Cell newCell)
        {
            current[WrapInt(y,width), WrapInt(y,height)] = newCell;
        }
        // public void AddCell(Point pos, Cell newCell)
        // {
        //     AddCell(pos.x, pos.y, newCell);
        // }
        public void SetCell(int x, int y, Cell newCell)
        {
            //Console.WriteLine($"Writing to Cell at X:{WrapInt(x,width)}, Y:{WrapInt(y,height)}");
            next[WrapInt(x,width), WrapInt(y,height)] = newCell;
        }
        public void SetCell(Point pos, Cell newCell)
        {
            SetCell(pos.x, pos.y, newCell);
        }
    }
}