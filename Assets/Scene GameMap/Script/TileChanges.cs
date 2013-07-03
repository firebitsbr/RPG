using UnityEngine;
using System;
using System.Collections;

public class TileChanges : MonoBehaviour
{
	
	public float TotalTiles;
	public int TileNumber;
	// Use this for initialization
	void Start ()
	{
        changeTile(TileNumber);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
    // update the tile 
    public void changeTile(int _tile)
    {
        TileNumber = _tile;
        Vector2 pt = new Vector2((1 / TotalTiles) * _tile, -1);
        renderer.material.SetTextureOffset("_MainTex", pt);
    }
    // update collidion based on the Map.COLLIDE array
    public void updateCollision()
    {
        this.rigidbody.detectCollisions = (bool)(Array.IndexOf(Map.COLLIDE, (int)TileNumber) >= 0);
    }
}

