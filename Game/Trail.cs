using System;
using Raylib_cs;
using Cycles_Game.Game.Casting;

namespace Cycles_Game.Game
{
    public class Trail : Actor
    {
        byte life;
        public Trail(Color color, byte lifetime) : base(color)
        {
            this.life = lifetime;
        }
        public override void Draw()
        {
            
        }
    }
}
