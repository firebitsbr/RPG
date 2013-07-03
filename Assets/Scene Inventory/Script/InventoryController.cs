using UnityEngine;
using System.Collections;

public class InventoryController : MonoBehaviour {

    private GameObject _itemSelected;

    public GameObject _itemList;
    public GameObject _itemDetail;
    public GameObject _characterController;
    public GameObject _windowQuest;
    public GameObject _saveQuest;

	void Start () {

        GlobalCharacter.Init();
        GlobalItens.Init();


	}

	void Update () {
	    


	}

    public void UpdateItemList()
    {
        _itemList.GetComponent<ListItensController>().UpdateFromGlobal();
        _characterController.GetComponent<WindowCharacterController>()._boxItemList.GetComponent<ListItensController>().UpdateFromGlobal();
        _itemDetail.GetComponent<ItemDetailController>().hideAll();
    }
    public void UpdateCharacter()
    {
        _characterController.GetComponent<WindowCharacterController>().UpdateFromGlobal();
    }


    public GameItem getItemSelected() {

        if (_itemSelected.GetComponent<ItemSlotController>() != null)
        {
            return _itemSelected.GetComponent<ItemSlotController>().item;
        }
        return _itemSelected.GetComponent<ItemSlotSlider>().item;
    }

    public GameObject itemSelected
    {
        get { return _itemSelected; }
        set { _itemSelected = value; }
    }
}
