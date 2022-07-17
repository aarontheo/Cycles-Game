using System;
using Raylib_cs;
using Cycles_Game.Services;

using Cycles_Game.Game.Grid;
namespace Cycles_Game.Directing
{
    public class Director
    {
        private VideoService videoService;
        private bool isRunning = false;
        public Director(VideoService videoService)
        {
            this.videoService = videoService;
        }
        public void StartGame(Grid grid)
        {
            isRunning = true;
            videoService.OpenWindow();
            while (!Raylib.WindowShouldClose())
            {
                if (isRunning)
                {
                    grid.Update();
                    videoService.ClearBuffer();
                    grid.Draw();
                    videoService.FlushBuffer();
                }
            }
            videoService.CloseWindow();
        }
    }
}