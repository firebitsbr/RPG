using UnityEngine;
using System.Collections;

public class ButtonInventory : MonoBehaviour {

    public bool _selected = false;
    public Color _selectedColor;
    public GameObject _window;
    public bool _restart = false;
    // @TODO: nothing

	void Start () {
	

	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && guiTexture.HitTest(Input.mousePosition))
        {
            SetSelected(!_selected);
        }
    }

    public void SetSelected(bool value)
    {
        if (value)
        {
            this.transform.parent.gameObject.GetComponent<MenuController>().updateButtons();
            this.GetComponent<GUITexture>().color = _selectedColor;
            _selected = true;
            if (_window != null)
            {
                _window.SetActive(true);
            }
        }
        else
        {
            this.GetComponent<GUITexture>().color = Color.gray;
            _selected = false;
            if (_window != null)
            {
                _window.SetActive(false);
            }
        }
    }
}
