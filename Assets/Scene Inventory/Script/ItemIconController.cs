using UnityEngine;
using System.Collections;

public class ItemIconController : MonoBehaviour {

    public int _iconNum = 1;
    public Texture _texture;
    private GameItem _item;
    public bool _hasItem;

	// Use this for initialization
	void Start () {
        //guiTexture.pixelInset = new Rect(guiTexture.pixelInset.x, guiTexture.pixelInset.y, 32, 32);
        //guiTexture.color = new Color(0, 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnGUI()
    {
        if (_hasItem)
        {
            GUI.DrawTextureWithTexCoords(new Rect(guiTexture.pixelInset.x + 6, Screen.height - guiTexture.pixelInset.y - 38, 32, 32), _texture, new Rect(0.05f * _iconNum, 0, 0.05f, 1f));
        }
    }

    public void addToSlot(GameObject slot)
    {

    }

    void OnMouseDown()
    {
        Debug.Log("Item clicked");
    }




    public GameItem item
    {
        get { return _item; }
        set { _item = value; }
    }
}
