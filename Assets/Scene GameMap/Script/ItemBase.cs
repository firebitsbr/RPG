using UnityEngine;
using System.Collections;

public class ItemBase : MonoBehaviour
{


    private GameItem _item;

	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    
	}

    public GameItem item
    {
        get { return _item; }
        set { _item = value; }
    }
}

