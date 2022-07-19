using System;
using Raylib_cs;
using Cycles_Game.Game.Casting;
using Cycles_Game.Services;

namespace Cycles_Game.Game
{
    public class Cycle : Actor
    {
        private InputService inputService;
        public Cycle(Color color, KeyboardKey up, KeyboardKey left, KeyboardKey down, KeyboardKey right) : base(color)
        {
            this.inputService = new InputService(left, right, up, down);
        }
        public override void Update(int maxX, int maxY)
        {
            this.vel = inputService.GetDirectionEx();
            base.Update(maxX, maxY);
        }
    }
}
