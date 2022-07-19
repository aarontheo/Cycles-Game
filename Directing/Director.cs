using System;
using Raylib_cs;
using Cycles_Game.Services;
using Cycles_Game.Game.Casting;

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
        public void StartGame(Cast cast,int maxX, int maxY, int cellSize)
        {
            isRunning = true;
            videoService.OpenWindow();
            while (!Raylib.WindowShouldClose())
            {
                if (isRunning)
                {
                    cast.Update(maxX/cellSize,maxY/cellSize);
                    videoService.ClearBuffer();
                    cast.Draw(cellSize);
                    videoService.FlushBuffer();
                }
            }
            videoService.CloseWindow();
        }
    }
}