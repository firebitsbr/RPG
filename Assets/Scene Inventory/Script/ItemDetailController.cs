using UnityEngine;
using System.Collections;

public class ItemDetailController : MonoBehaviour {

    public GameObject _specialName;
    public GameObject _specialDesc;

    public GameObject _textName;
    public GameObject _textDescription;
    public GameObject _buttonDelete;

    private InventoryController _inventoryController;

    // @TODO: nothing


	void Start () {

        _inventoryController = Camera.mainCamera.GetComponent<InventoryController>();

        _specialName.SetActive(false);
        _specialDesc.SetActive(false);

        _textName.SetActive(false);
        _textDescription.SetActive(false);
        
        _buttonDelete.SetActive(false);
        
	}

    public void hideAll()
    {

        _specialName.SetActive(false);
        _specialDesc.SetActive(false);

        _textName.SetActive(false);
        _textDescription.SetActive(false);
        _buttonDelete.SetActive(false);
    }

	
	// Update is called once per frame
	void Update () {
	    
	}

    public void showItemDetail(GameObject item)
    {
        _inventoryController.itemSelected = item;
        GameItem itm = _inventoryController.getItemSelected();

        switch (itm.type)
        {
            case ItemType.Equipment:

                _specialName.SetActive(true);
                _specialName.GetComponent<GUIText>().text = itm.special.name;

                _specialDesc.SetActive(true);
                _specialDesc.GetComponent<GUIText>().text = itm.special.description;

                break;
            case ItemType.Alchemy:

                _specialName.SetActive(false);
                _specialDesc.SetActive(false);

                break;
        }

        _textName.SetActive(true);
        _textDescription.SetActive(true);
        _textName.GetComponent<GUIText>().text = itm.name;
        _textDescription.GetComponent<GUIText>().text = itm.description;

        _buttonDelete.SetActive(true);
    }
}
