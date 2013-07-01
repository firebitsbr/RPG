using UnityEngine;
using System.Collections;

public class CharItemEquippedController : MonoBehaviour {

    public GameObject[] itens = new GameObject[4];


    // @TODO: nothing

	void Start () {

        GameItem itm = new GameItem();
        addItem(itm);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool addItem(GameItem item)
    {
        for (int i = 0; i < itens.Length; i++)
        {
            ItemSlotController slot = itens[i].GetComponent<ItemSlotController>();
            if (!slot._hasItem)
            {
                Debug.Log("AddItem:" + i);
                slot.addToSlot(item);
                return true;
            }
        }
        return false;
    }
    
}
