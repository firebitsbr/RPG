using UnityEngine;
using System.Collections;

public class ListItensController : MonoBehaviour {

	// Use this for initialization
    public GameObject slot;
    private float _height;
    private float _max;
    private ArrayList _slots;
    private int _numItens;

    // @TODO: insert item into inventory.

	void Start () {

        _max = 0;
        _numItens = 0;
        _slots = new ArrayList();

        for (int i = 0; i < 6; i++)
        {
            addRowSlots();
        }

        
        for (int i = 0; i < GlobalItens.inventory.Count; i++)
        {
            addItem(GlobalItens.inventory[i] as GameItem);
        }
        
	}

    void updateSize(int value)
    {
        GUITexture text = this.GetComponent("GUITexture") as GUITexture;
        text.pixelInset = new Rect(70, value-10, 165, 330 - value);

        _max = (float)(10 - value) / 320;
    }

    public void addRowSlots()
    {
        int col = (int)(_slots.Count / 3);
        int[] lin = new int[3] {80,130,180};
        int max = 270 - col * 50;

        for (int i = 0; i < 3; i++)
        {
            GameObject itmSlot = (Instantiate(slot) as GameObject);
            itmSlot.GetComponent<ItemSlotController>().diff = this.transform;
            itmSlot.GetComponent<ItemSlotController>().removeItem();
            GUITexture itm = itmSlot.GetComponent<GUITexture>();
            itm.pixelInset = new Rect(lin[i], max, 44, 44);
            itm.transform.parent = this.transform;

            _slots.Add(itmSlot);
        }
        if (max < 0)
        {
            updateSize(max);
        }
    }

    public void addItem(GameItem item)
    {
        if (_numItens == _slots.Count)
        {
            addRowSlots();
        }
        (_slots[_numItens] as GameObject).GetComponent<ItemSlotController>().addToSlot(item);
        _numItens++;
    }


    void Update()
    {
        
	}
    public void OnMouseDown()
    {
        _height = (float)(Input.mousePosition.y * 0.005 - this.transform.position.y);
    }
    void OnMouseUp()
    {

    }
    public void OnMouseDrag()
    {
        float newPos = (float)(Input.mousePosition.y * 0.005 - _height);
        if (newPos > _max)
        {
            newPos = _max;
        } else if (newPos < 0)
        {
            newPos = 0;
        }
        this.transform.position = new Vector3(0,newPos, 0);

    }
}
