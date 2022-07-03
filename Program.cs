using Cycles_Game.Directing;
using Cycles_Game.Services;
using Cycles_Game.Game.Casting;
using Raylib_cs;

int width = 400;
int height = 400;
int FPS = 60;
Color bgColor = Color.BLACK;
string title = "S N E K";

VideoService videoService = new VideoService(width,height,bgColor,title,FPS);
Director director = new Director(videoService);

Cast cast = new Cast();
Snake snake = new Snake(width / 2, height / 2, 10, 10, 10, Color.RED);
cast.Add("snakes", snake);
cast.Add("text", new TextActor(20, 20, "Hello!"));
director.StartGame(cast);