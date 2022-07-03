using System;
using Raylib_cs;

namespace Cycles_Game.Game.Casting
{
    public interface IActor
    {
        public void Update(int maxX,int maxY);
        public void Draw();
        public bool isColliding(IActor b);
        public Rectangle getBound();
    }
}
