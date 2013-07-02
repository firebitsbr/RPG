using UnityEngine;
using System.Collections;

public class CharFightController : MonoBehaviour {

    public bool _selectable;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (_selectable)
        {
            Debug.Log("Set as Target");
        }
    }


    public bool selectable
    {
        get { return _selectable; }
        set {
            if (value)
            {
                this.gameObject.renderer.material.color = Color.red;
            }
            else
            {
                this.gameObject.renderer.material.color = Color.grey;
            }
            _selectable = value;
        }
    }
}
