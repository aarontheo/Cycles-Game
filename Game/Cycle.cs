using System;
using Raylib_cs;
using Cycles_Game.Game.Casting;
using Cycles_Game.Services;

namespace Cycles_Game.Game
{
    public class Cycle : Actor
    {
        private InputService inputService;
        private int direction = 0;
        public int trailLife = 100;
        public List<Trail> trail = new List<Trail>();
        public Cycle(int x,int y,Color color, KeyboardKey left, KeyboardKey right) : base(color,x,y)
        {
            this.inputService = new InputService(left, right);
        }
        public override void Update(int maxX, int maxY)
        {
            direction = (direction + inputService.GetLR()) % 4;
            if (direction == -1) direction = 3;
            switch (direction)
            {
                case 0: //up
                    this.vel = new Point(0, -1);
                    break;
                case 1: //right
                    this.vel = new Point(1, 0);
                    break;
                case 2: //down
                    this.vel = new Point(0, 1);
                    break;
                case 3: //left
                    this.vel = new Point(-1, 0);
                    break;
            }
            trail.Add(new Trail(pos.x, pos.y, this.color, trailLife));
            List<Trail> garbo = new List<Trail>();
            foreach (Trail tr in trail)
            {
                tr.Update();
                if (tr.lifetime <= 0)
                {
                    garbo.Add(tr);
                }
            }
            foreach (Trail tr in garbo)
            {
                trail.Remove(tr);
            }
            base.Update(maxX, maxY);
        }
        public override void Draw(int cellSize)
        {
            foreach (Trail t in trail)
            {
                t.Draw(cellSize);
            }
            base.Draw(cellSize);
        }
        public bool isColliding(Cycle b)
        {
            foreach (Trail tr in b.trail)
            {
                if (tr.isColliding(this))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
