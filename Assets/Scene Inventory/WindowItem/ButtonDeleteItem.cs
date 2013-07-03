using UnityEngine;
using System.Collections;

public class ButtonDeleteItem : MonoBehaviour {


    InventoryController _invController;

	void Start () {
        _invController = Camera.main.GetComponent<InventoryController>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnMouseDown()
    {
        if (_invController.itemSelected != null)
        {
            GlobalItens.RemoveFromInventory(_invController.getItemSelected());
            _invController.UpdateItemList();
        }
    }
}
