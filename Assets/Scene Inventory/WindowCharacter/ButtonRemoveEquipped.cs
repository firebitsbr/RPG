using UnityEngine;
using System.Collections;

public class ButtonRemoveEquipped : MonoBehaviour {

    public GameObject _listItens;
    public GameObject _itemDetail;
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GameObject itm = _itemDetail.GetComponent<CharItemDetailController>().selectedItem;
        if (itm != null)
        {
            ItemSlotController slot = itm.GetComponent<ItemSlotController>();
            _listItens.GetComponent<ListItensController>().addItem(slot.item);
            slot.removeItem();

            CharItemDetailController det = _itemDetail.GetComponent<CharItemDetailController>();
            det.hideAll();
        }
    }
}