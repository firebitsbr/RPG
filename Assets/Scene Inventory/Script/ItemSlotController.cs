using UnityEngine;
using System.Collections;

public class ItemSlotController : MonoBehaviour {

    public int _iconNum = 1;
    public Texture _texture;
    private GameItem _item;
    public bool _hasItem = false;


    // @TODO: nothing

	void Start () {

        _item = new GameItem();
        _item.sprite = 4;
        _item.type = ItemType.Equipment;
        _item.name = "item Test";
        _item.description = "description of the item";
        _item.attack = new GameSkill();
        _item.attack.name = "Skill Attack";
        _item.special = new GameSkill();
        _item.special.name = "Skill Special";

        addToSlot(_item);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if (_hasItem)
        {
            Vector3 diff = GameObject.Find("BoxItemDetail").transform.position;
            GUI.DrawTextureWithTexCoords(new Rect(guiTexture.pixelInset.x + 6, Screen.height - guiTexture.pixelInset.y - 38 - diff.y * Screen.height, 32, 32), _texture, new Rect(0.05f * _iconNum, 0, 0.05f, 1f));
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
        Debug.Log("Item clicked");
        if (_hasItem)
        {
            ItemDetailController _detail = GameObject.Find("/WindowItem/BoxItemDetail").GetComponent("ItemDetailController") as ItemDetailController;
            _detail.showItemDetail(this.gameObject);
        }
    }

    public GameItem item
    {
        get { return _item; }
        set { _item = value; }
    }
}
