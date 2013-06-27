using UnityEngine;
using System.Collections;

public class ListItensController : MonoBehaviour {

	// Use this for initialization
    public GameObject slot;
    private float _height;
    private float _max;
    private GameObject[] _slots;

    // @TODO: insert item into inventory. better scroll

	void Start () {

        int total = 40;
        int max = 100;
        _max = 0;

        _slots = new GameObject[50];

        for (int i = 0; i < total; i++)
        {
            int col = (int)(i/3);
            int lin = 0;
            switch (i % 3)
            {
                case 0:
                    lin = 80;
                    break;
                case 1:
                    lin = 130;
                    break;
                case 2:
                    lin = 180;
                    break;
            }
            GameObject itmSlot = (Instantiate(slot) as GameObject);
            GUITexture itm = itmSlot.GetComponent("GUITexture") as GUITexture;
            max = 270 - col * 50;
            itm.pixelInset = new Rect(lin, max, 44, 44);
            itm.transform.parent = this.transform;
            _slots[i] = itmSlot;
        }
        if (max < 0)
        {
            updateSize(max);
        }
	}

    void updateSize(int value)
    {
        GUITexture text = this.GetComponent("GUITexture") as GUITexture;
        text.pixelInset = new Rect(70, value-10, 165, 330 - value);

        _max = (float)(10 - value) / 320;
    }


    public void addItem(GameItem item)
    {
        for (int i = 0; i < 40; i++)
        {
            
        }

    }


    void Update()
    {
        
	}
    void OnMouseDown()
    {
        _height = (float)(Input.mousePosition.y * 0.005 - this.transform.position.y);
    }
    void OnMouseUp()
    {

    }
    void OnMouseDrag()
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
