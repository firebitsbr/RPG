using UnityEngine;
using System.Collections;

public class ItemDetailController : MonoBehaviour {

    public GameObject _attackName;
    public GameObject _attackDesc;
    
    public GameObject _specialName;
    public GameObject _specialDesc;

    public GameObject _textName;
    public GameObject _textDescription;

    private GameObject _selectedItem;

    // @TODO: nothing


	void Start () {


        _attackName.SetActive(false);
        _attackDesc.SetActive(false);
        

        _specialName.SetActive(false);
        _specialDesc.SetActive(false);

        _textName.SetActive(false);
        _textDescription.SetActive(false);
	}

    public void hideAll()
    {
        _selectedItem = null;

        _attackName.SetActive(false);
        _attackDesc.SetActive(false);

        _specialName.SetActive(false);
        _specialDesc.SetActive(false);

        _textName.SetActive(false);
        _textDescription.SetActive(false);
    }

	
	// Update is called once per frame
	void Update () {
	    
	}

    public void showItemDetail(GameObject item)
    {

        _selectedItem = item;
        GameItem itm = _selectedItem.GetComponent<ItemSlotController>().item;

        switch (itm.type)
        {
            case ItemType.Equipment:

                _attackName.SetActive(true);
                _attackName.GetComponent<GUIText>().text = itm.attack.name;

                _attackDesc.SetActive(true);
                _attackDesc.GetComponent<GUIText>().text = itm.attack.description;

                _specialName.SetActive(true);
                _specialName.GetComponent<GUIText>().text = itm.attack.name;

                _specialDesc.SetActive(true);
                _specialDesc.GetComponent<GUIText>().text = itm.special.description;

                break;
            case ItemType.Alchemy:

                _attackName.SetActive(false);
                _attackDesc.SetActive(false);

                _specialName.SetActive(false);
                _specialDesc.SetActive(false);

                break;
        }

        _textName.SetActive(true);
        _textDescription.SetActive(true);
        _textName.GetComponent<GUIText>().text = itm.name;
        _textDescription.GetComponent<GUIText>().text = itm.description;
    }


    public GameObject selectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; }
    }
}
