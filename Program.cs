using Cycles_Game.Directing;
using Cycles_Game.Services;
using Cycles_Game.Game.Casting;
using Cycles_Game.Game;
using Raylib_cs;

int width = 400;
int height = 400;
int cellSize = 10;
int FPS = 25;
Color bgColor = Color.BLACK;
string title = "Cycles";

VideoService videoService = new VideoService(width, height, bgColor, title, FPS);
Director director = new Director(videoService);
Cast cast = new Cast();
cast.Add("cycles",new Cycle(10,20,Color.BLUE, KeyboardKey.KEY_A,KeyboardKey.KEY_D));
cast.Add("cycles",new Cycle(30,20,Color.ORANGE, KeyboardKey.KEY_LEFT, KeyboardKey.KEY_RIGHT));

director.StartGame(cast,width,height,cellSize);