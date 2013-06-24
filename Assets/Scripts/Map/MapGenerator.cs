using UnityEngine;
using System.Collections;


public class MapGenerator : MonoBehaviour
{
	
	public Vector2 RoomSize;
	public GameObject tile;
	
	// Use this for initialization
	void Start ()
	{
        //generateMap();
        loadMap(Map.getMap(), 10, 10);
	}
    // load map from a bidimensional array
    void loadMap(int[,] map, int w, int h)
    {
        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                Vector3 pos = new Vector3(i * 16, j * 16, 1);
                Quaternion qrt = Quaternion.identity;
                GameObject inst = Instantiate(tile, pos, qrt) as GameObject;
                TileChanges tc = inst.GetComponent<TileChanges>();
                if (map[j, i] == Map.TILE_DOOR_WOOD_CLOSED)
                {
                    tc.gameObject.AddComponent("ActionTile");
                    tc.gameObject.GetComponent<ActionTile>().spritePressed = 15;
                }

                tc.changeTile(map[j,i]);
                tc.updateCollision();
            }
        }
    }

    void insertComponents(GameObject go, int num)
    {
        switch (num)
        {
            case Map.TILE_DOOR_WOOD_CLOSED:

                break;
        }
    }

    // random map generator
    void generateMap()
    {
        for (int i = 0; i < RoomSize.x; i++)
        {
            for (int j = 0; j < RoomSize.y; j++)
            {

                Vector3 pos = new Vector3(i * 16, j * 16, 1);
                Quaternion qrt = Quaternion.identity;
                GameObject inst = Instantiate(tile, pos, qrt) as GameObject;
                TileChanges tc = inst.GetComponent<TileChanges>();
                
                if (i == 0 || j == 0 || i == RoomSize.x - 1 || j == RoomSize.y - 1)
                {
                    tc.changeTile(0);
                    tc.updateCollision();
                }
                else
                {
                    tc.changeTile(6);
                    tc.updateCollision();
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

