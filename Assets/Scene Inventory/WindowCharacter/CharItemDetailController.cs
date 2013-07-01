using UnityEngine;
using System.Collections;

public class CharItemDetailController : MonoBehaviour {

    public GameObject _itemName;
    public GameObject _itemDescription;

    public GameObject _attackIcon;
    public GameObject _attackText;

    public GameObject _specialIcon;
    public GameObject _specialText;

    private GameObject _selectedItem;
	
    // @TODO: nothing

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void showItemDetail(GameObject obj)
    {
        _selectedItem = obj;
        GameItem item = obj.GetComponent<ItemSlotController>().item;

        _itemName.GetComponent<GUIText>().text = item.name;
        _itemDescription.GetComponent<GUIText>().text = item.name;

        switch (item.type)
        {
            case ItemType.Alchemy:

                _attackIcon.SetActive(false);
                _attackText.SetActive(false);
                _specialIcon.SetActive(false);
                _specialText.SetActive(false);

                break;
            case ItemType.Equipment:

                _attackIcon.SetActive(true);
                _attackText.SetActive(true);
                _attackText.GetComponent<GUIText>().text = item.name;

                _specialIcon.SetActive(true);
                _specialText.SetActive(true);
                _specialText.GetComponent<GUIText>().text = item.name;

                break;
        }
    }

    public void hideAll()
    {
        _itemName.SetActive(false);
        _itemDescription.SetActive(false);

        _attackIcon.SetActive(false);
        _attackText.SetActive(false);

        _specialIcon.SetActive(false);
        _specialText.SetActive(false);
    }

    public GameObject selectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; }
    }
}
