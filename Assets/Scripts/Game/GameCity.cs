using UnityEngine;
using System.Collections;

public class GameCity {

    private Vector2 _point;
    private string _name;
    private int _sprite;
    private int[][] _map;
    private ArrayList _npcs;
	
	void Start () {
	    
	}



    public Vector2 point
    {
        get { return _point; }
        set { _point = value; }
    }
    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int sprite
    {
        get { return _sprite; }
        set { _sprite = value; }
    }
    public int[][] map
    {
        get { return _map; }
        set { _map = value; }
    }
    public ArrayList npcs
    {
        get { return _npcs; }
        set { _npcs = value; }
    }
    /***********************************************************************************************************/
}