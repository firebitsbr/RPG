using UnityEngine;
using System.Collections;

public class ItemSlotController : MonoBehaviour {

    public int _iconNum = 1;
    public Texture _texture;
    public int itemNum;

    private GameItem _item;
    private bool _hasItem = false;
    private ItemDetailController _boxItem;
    private WindowCharacterController _windowChar;

    private ItemType _itemTypeSlot;
    private EquipmentType _equipTypeSlot;


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
            GUI.color = _item.color;
            GUI.DrawTextureWithTexCoords(
                    new Rect(guiTexture.pixelInset.x + 6, Screen.height - guiTexture.pixelInset.y - 38, 32, 32), 
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

    void OnMouseDown()
    {
        if (_hasItem)
        {
            Debug.Log("Item clicked");
            _windowChar.currentItemSelected = _item;
            _boxItem.showItemDetail(this.gameObject);
        }

        _windowChar.itemNumSelected = itemNum;
        _windowChar.itemSelected = _itemTypeSlot;
        _windowChar.equipmentSelected = _equipTypeSlot;
        
    }

    public ItemType itemTypeSlot
    {
        get { return _itemTypeSlot; }
        set { _itemTypeSlot = value; }
    }
    public EquipmentType equipTypeSlot
    {
        get { return _equipTypeSlot; }
        set { _equipTypeSlot = value; }
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
