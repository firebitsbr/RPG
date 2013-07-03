using UnityEngine;
using System.Collections;

public class ButtonDeleteItem : MonoBehaviour {


    // @TODO: nothing

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnMouseDown()
    {
        Debug.Log("DELETE");

        ItemDetailController itm = GameObject.Find("/WindowItem/BoxItemDetail").GetComponent<ItemDetailController>();

        itm.selectedItem.GetComponent<ItemSlotController>().hasItem = false;
        GameObject.Find("/WindowItem/BoxItemDetail").GetComponent<ItemDetailController>().hideAll();
    }
}
