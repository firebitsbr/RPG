using UnityEngine;
using System.Collections;

public class ButonUseItem : MonoBehaviour {

    // @TODO: verify if is item or equipment. add item to equipped
    public GameObject _boxItem;
    public GameObject _boxItemDetail;
    public GameObject _boxEquipment;

    private InventoryController _inventoryController;

	void Start () {
        _inventoryController = camera.GetComponent<InventoryController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {


        GameItem itm = _inventoryController.getItemSelected();

        switch (itm.type)
        {
            case ItemType.Alchemy:

                //_boxItem.GetComponent<CharItemEquippedController>().addItem(itm.item);
                
                break;
            case ItemType.Equipment:

                //_boxEquipment.GetComponent<CharEquippedController>().addEquipment(itm.item);
                
                break;
        }

    }
}
