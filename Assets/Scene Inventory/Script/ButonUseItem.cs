using UnityEngine;
using System.Collections;

public class ButonUseItem : MonoBehaviour {

    // @TODO: verify if is item or equipment. add item to equipped
    public GameObject _boxItem;
    public GameObject _boxItemDetail;
    public GameObject _boxEquipment;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        Debug.Log("USE ITEM");

        ItemDetailController idc = _boxItemDetail.GetComponent<ItemDetailController>();

        GameItem itm = idc.selectedItem.GetComponent<ItemSlotController>().item;

        switch (itm.type)
        {
            case ItemType.Alchemy:

                _boxItem.GetComponent<CharItemEquippedController>().addItem(itm);
                
                break;
            case ItemType.Equipment:

                _boxEquipment.GetComponent<CharEquippedController>().addEquipment(itm);
                
                break;
        }

        _boxItemDetail.GetComponent<ItemDetailController>().hideAll();

    }
}
