using UnityEngine;
using System;
using System.Collections;

public class TileChanges : MonoBehaviour
{
	
	public float TotalTiles;
	public float TileNumber;
	// Use this for initialization
	void Start ()
	{	
		float num = 1/TotalTiles;
		Vector2 pt = new Vector2((num) * TileNumber,-1);
		this.renderer.materials[0].SetTextureOffset("_MainTex", pt);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
    // update the tile 
    public void changeTile(float _tile)
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

