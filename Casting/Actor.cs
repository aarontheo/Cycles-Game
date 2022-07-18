using System;
using Raylib_cs;
using Cycles_Game.Game;

//TODO: Maybe change the pos Vect back to a point?
namespace Cycles_Game.Game.Casting
{
    public class Actor : IActor
    {
        public double heading = 0;
        public Point size;
        public Point pos;
        public Point vel = new Point(0, 0);
        public Actor(int x = 0, int y = 0, int width = 10, int height = 10)
        {
            pos = new Point(x, y);
            size = new Point(width, height);
        }
        public virtual void Draw()
        {
            Raylib.DrawRectangle((int)pos.x, (int)pos.y, size.x, size.y, color);
        }
        public virtual void Draw(int cellSize)
        {
            Raylib.DrawRectangle((int)pos.x*cellSize, (int)pos.y*cellSize, size.x*cellSize, size.y*cellSize, color);
        }
        public virtual void Update(int maxX, int maxY)
        {
            pos = pos + vel;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxX"></param>
        /// <param name="maxY"></param>
        /// <param name="wraparound">Ok so this parameter isn't used in </param>
        public void Wraparound(int maxX,int maxY)
        {
            //this bit allows for screen wraparound
            bool wrapped = false;
            if (pos.x < 0 - size.x)
            {
                pos.x = maxX;
                wrapped = true;
            }
            else if (pos.x > maxX)
            {
                pos.x = 0 - size.x;
                wrapped = true;
            }
            if (pos.y < 0 - size.y)
            {
                pos.y = maxY;
                wrapped = true;
            }
            else if (pos.y > maxY)
            {
                pos.y = 0 - size.y;
                wrapped = true;
            }
        }
        public virtual Rectangle getBound()
        {
            //return new Rectangle(pos.x, pos.y, fontSize, fontSize);
            return new Rectangle(pos.x, pos.y, size.x, size.y);
        }
        public bool isColliding(IActor b)
        {
            return Raylib.CheckCollisionRecs(this.getBound(), b.getBound());
        }
    }
}