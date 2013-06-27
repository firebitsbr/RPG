using UnityEngine;
using System.Collections;

public class ItemSlotController : MonoBehaviour {

    public int _iconNum = 1;
    public Texture _texture;
    private GameItem _item;
    public bool _hasItem = false;
    public Transform diff;

    // @TODO: nothing

	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if (_hasItem)
        {
            if (diff != null)
            {
                GUI.DrawTextureWithTexCoords(
                        new Rect(guiTexture.pixelInset.x + 6, Screen.height - guiTexture.pixelInset.y - 38 - diff.position.y * Screen.height, 32, 32), 
                        _texture, new Rect(0.05f * _iconNum, 0, 0.05f, 1f));
            }
            else
            {
                GUI.DrawTextureWithTexCoords(
                        new Rect(guiTexture.pixelInset.x + 6, Screen.height - guiTexture.pixelInset.y - 38, 32, 32), 
                        _texture, new Rect(0.05f * _iconNum, 0, 0.05f, 1f));
            }
        }
    }

    public void addToSlot(GameItem slot)
    {
        _item = slot;

        _hasItem = true;
        _iconNum = slot.sprite;
    }

    public void removeItem()
    {
        _hasItem = false;
        _item = null;
    }

    void OnMouseDrag()
    {
        if (diff != null)
        {
            diff.GetComponent<ListItensController>().OnMouseDrag();
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Item clicked");
        if (_hasItem)
        {
            ItemDetailController _detail = GameObject.Find("/WindowItem/BoxItemDetail").GetComponent<ItemDetailController>();
            _detail.showItemDetail(this.gameObject);
        }
        if (diff != null)
        {
            diff.GetComponent<ListItensController>().OnMouseDown();
        }
    }

    public GameItem item
    {
        get { return _item; }
        set { _item = value; }
    }
}
