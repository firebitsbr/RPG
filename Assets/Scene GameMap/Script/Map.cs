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

    public static TileMapItem[,] getMap() 
    {

        TileMapItem fl = new TileMapItem();
        fl.layer1 = 6; fl.layer2 = -1; fl.collide = false;
        TileMapItem wl = new TileMapItem();
        wl.layer1 = 6; wl.layer2 = 2; wl.collide = true;
        TileMapItem dr = new TileMapItem();
        dr.layer1 = 6; dr.layer2 = 14; dr.collide = true;
        dr.action = ActionTileType.ChangeSpriteToNotCollide;
        dr.value = TILE_DOOR_WOOD_OPEN;

        TileMapItem tt = new TileMapItem();
        tt.layer1 = 6; tt.collide = true; tt.layer2 = TILE_CARPET;
        tt.action = ActionTileType.GotoLocation;
        tt.value = new int[2] { 6, 6 };

        TileMapItem bb = new TileMapItem();
        bb.layer1 = 6; bb.collide = true; bb.layer2 = TILE_STAIR_DOWN;
        // bb.action = ActionTileType.ba;
        bb.value = new int[2] { 6, 6 };

        TileMapItem[,] tilemap = new TileMapItem[10, 10] {   
            { wl, wl, wl, wl, wl, dr, wl, wl, wl, wl },
            { wl, fl, fl, fl, fl, fl, fl, fl, fl, wl },
            { wl, fl, fl, fl, fl, fl, fl, fl, fl, wl },
            { wl, fl, fl, fl, fl, fl, fl, fl, fl, dr },
            { wl, fl, fl, fl, fl, fl, fl, fl, fl, wl },
            { dr, fl, fl, fl, fl, fl, fl, fl, fl, wl },
            { wl, fl, fl, fl, fl, fl, fl, fl, fl, dr },
            { wl, fl, fl, fl, fl, fl, fl, fl, fl, wl },
            { wl, tt, fl, fl, fl, fl, fl, fl, fl, wl },
            { wl, wl, wl, wl, dr, wl, wl, wl, wl, wl }
        };

        return tilemap;
    }
}

public struct TileMapItem
{
    public int layer1;
    public int layer2;
    public bool collide;
    public ActionTileType action;
    public object value;
};