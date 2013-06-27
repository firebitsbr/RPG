using UnityEngine;
using System.Collections;

public class ItemDetailController : MonoBehaviour {

    public GameObject _attackIcon;
    public GameObject _attackText;
    
    public GameObject _specialIcon;
    public GameObject _specialText;

    public GameObject _textName;
    public GameObject _textDescription;

    private GameObject _selectedItem;

    // @TODO: nothing


	void Start () {


        _attackIcon.SetActive(true);
        (_attackText.GetComponent("GUIText") as GUIText).text = "attack\nDescription";

        _specialIcon.SetActive(true);
        (_specialText.GetComponent("GUIText") as GUIText).text = "Special\nDescription";

        (_textName.GetComponent("GUIText") as GUIText).text = "Item Name";
        (_textDescription.GetComponent("GUIText") as GUIText).text = "Item Description";
	}

    public void hideAll()
    {
        _selectedItem = null;

        _attackIcon.SetActive(false);
        _attackText.SetActive(false);

        _specialIcon.SetActive(false);
        _specialText.SetActive(false);

        _textName.SetActive(false);
        _textDescription.SetActive(false);
    }

	
	// Update is called once per frame
	void Update () {
	    
	}

    public void showItemDetail(GameObject item)
    {

        _selectedItem = item;
        GameItem itm = (_selectedItem.GetComponent("ItemSlotController") as ItemSlotController).item;

        switch (itm.type)
        {
            case ItemType.Equipment:
                _attackIcon.SetActive(true);
                _attackText.SetActive(true);
                (_attackText.GetComponent("GUIText") as GUIText).text = itm.attack.name;

                _specialIcon.SetActive(true);
                _specialText.SetActive(true);
                (_specialText.GetComponent("GUIText") as GUIText).text = itm.special.name;
                break;
            case ItemType.Alchemy:
                _attackIcon.SetActive(false);
                _attackText.SetActive(false);

                _specialIcon.SetActive(false);
                _specialText.SetActive(false);
                break;
        }

        _textName.SetActive(true);
        _textDescription.SetActive(true);
        (_textName.GetComponent("GUIText") as GUIText).text = itm.name;
        (_textDescription.GetComponent("GUIText") as GUIText).text = itm.description;

    }




    public GameObject selectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; }
    }
}
