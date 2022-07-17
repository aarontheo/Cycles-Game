using Cycles_Game.Directing;
using Cycles_Game.Services;
using Cycles_Game.Game.Grid;
using Cycles_Game.Game.Grid.CellTypes;
using Raylib_cs;

int width = 400;
int height = 400;
int cellSize = 10;
int FPS = 1;
Color bgColor = Color.BLACK;
string title = "Cycles";

VideoService videoService = new VideoService(width, height, bgColor, title, FPS);
Director director = new Director(videoService);

Grid grid = new Grid(height / cellSize, width / cellSize, cellSize);

Cycle cyclea = new Cycle(Color.BLUE, new KeyboardKey[] { KeyboardKey.KEY_W, KeyboardKey.KEY_A, KeyboardKey.KEY_S, KeyboardKey.KEY_D });
Cycle cycleb = new Cycle(Color.ORANGE, new KeyboardKey[] { KeyboardKey.KEY_UP, KeyboardKey.KEY_LEFT, KeyboardKey.KEY_DOWN, KeyboardKey.KEY_RIGHT });

director.StartGame(grid);