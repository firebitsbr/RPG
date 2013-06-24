using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Map
{
    public const int TILE_WALL = 0;
    public const int TILE_WALL_LIGHT_HIGH = 1;
    public const int TILE_WALL_LIGHT_LOW = 2;
    public const int TILE_WALL_BROKEN = 3;
    public const int TILE_FLOOR_LIGHT = 4;
    public const int TILE_FLOOR_DARK = 5;
    public const int TILE_FLOOR_BROKEN = 6;
    public const int TILE_STAIR_UP = 7;
    public const int TILE_STAIR_DOWN = 8;
    public const int TILE_HOLE = 9;
    public const int TILE_FLOOR_DOOR_CLOSED = 10;
    public const int TILE_FLOOR_DOOR_OPEN = 11;
    public const int TILE_WOOD = 12;
    public const int TILE_CARPET = 13;
    public const int TILE_DOOR_WOOD_CLOSED = 14;
    public const int TILE_DOOR_WOOD_OPEN = 15;

    public static int[] COLLIDE = {0,1,2,3,14};

    public static int[,] getMap() 
    {
        int[,] _map = new int[10, 10] 
            {   { 1, 1, 1, 1, 1, 14, 1, 1, 1, 1 },
                { 2, 6, 6, 6, 6,  6, 6, 6, 6, 1 },
                { 2, 6, 6, 6, 6,  6, 6, 6, 6, 14 },
                { 2, 6, 6, 6, 6,  6, 6, 6, 6, 1 },
                { 2, 6, 6, 6, 6,  6, 6, 6, 6, 1 },
                { 2, 6, 6, 6, 6,  6, 6, 6, 6, 14 },
                { 2, 6, 6, 6, 6,  6, 6, 6, 6, 1 },
                {14, 6, 6, 6, 6,  6, 6, 6, 6, 1 },
                { 2, 6, 6, 6, 6,  6, 6, 6, 6, 1 },
                { 1, 1, 1, 1, 1, 14, 1, 1, 1, 1 }
            };
        

        return _map;
    }
}

