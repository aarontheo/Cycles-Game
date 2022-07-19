using System;
using Raylib_cs;
using Cycles_Game.Game.Casting;

namespace Cycles_Game.Game
{
    public class Trail : Actor
    {
        public int lifetime;
        private int maxLife;
        public Trail(int x, int y, Color color, int lifetime) : base(color,x,y)
        {
            this.lifetime = lifetime;
            this.maxLife = lifetime;
        }
        public void Update()
        {
            //this.color.a = (byte)(maxLife/lifetime*255);
            this.lifetime--;
        }
    }
}
