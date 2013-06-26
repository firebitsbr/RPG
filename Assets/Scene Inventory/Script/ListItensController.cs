using UnityEngine;
using System.Collections;

public class ListItensController : MonoBehaviour {

	// Use this for initialization
    public GameObject slot;
    private float _height;
    private float _max;

	void Start () {

        int total = 40;
        int max = 100;
        _max = 0;

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
            GUITexture itm = (Instantiate(slot) as GameObject).GetComponent("GUITexture") as GUITexture;
            max = 270 - col * 50;
            itm.pixelInset = new Rect(lin, max, 44, 44);
            itm.transform.parent = this.transform;
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

    // Update is called once per frame
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
        Debug.Log(newPos);
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
