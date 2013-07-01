using UnityEngine;
using System.Collections;

public class ButtonAction : MonoBehaviour
{


    public bool _selected = false;
    public Color _selectedColor;
	
    public GameObject boxAction;
    public OptionType _option;

	void Start () {
        
	}

    void OnGUI()
    {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && guiTexture.HitTest(Input.mousePosition))
        {
            SetSelected(!_selected);
        }
	}

    public void SetSelected(bool value)
    {
        if (value)
        {
            this.transform.parent.gameObject.GetComponent<ButtonActionController>().updateButtons();
            this.GetComponent<GUITexture>().color = _selectedColor;
            boxAction.SetActive(true);
            boxAction.GetComponent<BoxAction>().loadCharSkill(_option);
            _selected = true;
        }
        else
        {
            this.GetComponent<GUITexture>().color = Color.gray;
            boxAction.SetActive(false);
            _selected = false;
        }
    }
}
