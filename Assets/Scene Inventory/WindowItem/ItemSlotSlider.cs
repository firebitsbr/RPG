using UnityEngine;
using System.Collections;

public class ItemSlotSlider : MonoBehaviour {

    public int _iconNum = 1;
    public Texture _texture;
    public Transform diff;

    private GameItem _item;
    private bool _hasItem = false;
    private ItemDetailController _boxItem;


	void Start () {
        _boxItem = GameObject.Find("BoxItemDetail").GetComponent<ItemDetailController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if (_hasItem)
        {
            GUI.DrawTextureWithTexCoords(
                    new Rect(guiTexture.pixelInset.x + 6, Screen.height - guiTexture.pixelInset.y - 38 - diff.position.y * Screen.height, 32, 32),
                    _texture, new Rect(0.05f * _iconNum, 0, 0.05f, 1f));
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
        diff.GetComponent<ListItensController>().OnMouseDrag();
    }

    void OnMouseDown()
    {
        Debug.Log("Item clicked");
        if (_hasItem)
        {
            _boxItem.showItemDetail(this.gameObject);
        }
        else
        {
            Debug.Log("show itens do equip");
        }
        diff.GetComponent<ListItensController>().OnMouseDown();
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
