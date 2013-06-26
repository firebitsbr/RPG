using UnityEngine;
using System.Collections;

public class ItemDetailController : MonoBehaviour {

    public GameObject _attackIcon;
    public GameObject _attackText;
    
    public GameObject _specialIcon;
    public GameObject _specialText;

    public GameObject _textName;
    public GameObject _textDescription;

    private GameItem _selectedItem;

	// Use this for initialization
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
    }

	
	// Update is called once per frame
	void Update () {
	    
	}

    public void showItemDetail(GameItem item)
    {
        _selectedItem = item;

        switch (_selectedItem.type)
        {
            case ItemType.Equipment:
                _attackIcon.SetActive(true);
                _attackText.SetActive(true);
                (_attackText.GetComponent("GUIText") as GUIText).text = _selectedItem.special.description;

                _specialIcon.SetActive(true);
                _specialText.SetActive(true);
                (_specialText.GetComponent("GUIText") as GUIText).text = _selectedItem.special.name;
                break;
            case ItemType.Alchemy:
                _attackIcon.SetActive(false);
                _attackText.SetActive(false);

                _specialIcon.SetActive(false);
                _specialText.SetActive(false);
                break;
        }

        (_textName.GetComponent("GUIText") as GUIText).text = _selectedItem.name;
        (_textDescription.GetComponent("GUIText") as GUIText).text = _selectedItem.description;

    }




    public GameItem selectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; }
    }
}
