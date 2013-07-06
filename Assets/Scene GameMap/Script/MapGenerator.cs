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

    void GenerateTile(TileMapItem itm, int _x, int _y)
    {
        if(itm.layer1 >= 0) {
            Vector3 pos = new Vector3(_x * 16, _y * 16, 1);
            Quaternion qrt = Quaternion.identity;
            GameObject inst = Instantiate(tile, pos, qrt) as GameObject;
            TileChanges tc = inst.GetComponent<TileChanges>();

            tc.changeTile(itm.layer1);
            tc.updateCollision(false);
        }
        if (itm.layer2 >= 0)
        {
            Vector3 pos = new Vector3(_x * 16, _y * 16, 0);
            Quaternion qrt = Quaternion.identity;
            GameObject inst = Instantiate(tile, pos, qrt) as GameObject;
            TileChanges tc = inst.GetComponent<TileChanges>();

            if (itm.action != ActionTileType.Unknown)
            {
                tc.gameObject.AddComponent("ActionTile");
                tc.gameObject.GetComponent<ActionTile>()._actionType = itm.action;
                switch (itm.action)
                {
                    case ActionTileType.ChangeSpriteToCollide:
                        tc.gameObject.GetComponent<ActionTile>().actionValue = itm.value;
                        tc.gameObject.GetComponent<ActionTile>().spriteCollision = true;

                        break;
                    case ActionTileType.ChangeSpriteToNotCollide:

                        tc.gameObject.GetComponent<ActionTile>().actionValue = itm.value;
                        tc.gameObject.GetComponent<ActionTile>().spriteCollision = false;

                        break;
                    case ActionTileType.GotoLocation:

                        tc.gameObject.collider.isTrigger = true;
                        tc.gameObject.GetComponent<ActionTile>().actionValue = itm.value;
                        tc.gameObject.GetComponent<ActionTile>().tooltip = "has action";

                        break;
                }
            }

            tc.changeTile(itm.layer2);
            tc.updateCollision(itm.collide);
        }
    }
    
    void loadMap(TileMapItem[,] map, int w, int h)
    {
        
        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                GenerateTile(map[j, i], i, j);
            }
        }
    }
}

