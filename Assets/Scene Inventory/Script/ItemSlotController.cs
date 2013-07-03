using UnityEngine;
using System.Collections;

public class ItemSlotController : MonoBehaviour {

    public int _iconNum = 1;
    public Texture _texture;
    public Transform diff;

    private GameItem _item;
    private bool _hasItem = false;
    private ItemDetailController _boxItem;
    private WindowCharacterController _windowChar;

    // @TODO: nothing

	void Start () {

        _windowChar = GameObject.Find("WindowCharacter").GetComponent<WindowCharacterController>();
        _boxItem = GameObject.Find("BoxItemDetail").GetComponent<ItemDetailController>();
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
            _windowChar.currentItemSelected = _item;
            _boxItem.showItemDetail(this.gameObject);
        }
        else
        {
            Debug.Log("show itens do equip");
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
    public bool hasItem
    {
        get { return _hasItem; }
        set { _hasItem = value; }
    }
}
