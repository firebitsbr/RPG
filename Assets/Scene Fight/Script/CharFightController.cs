using UnityEngine;
using System.Collections;

public class CharFightController : MonoBehaviour {

    public bool _selectable;
    private FightController _fight;
    private GameObject _children;
    private GameCharacter _character;

	void Start () {
        _fight = Camera.main.GetComponent<FightController>();
        _children = transform.GetChild(0).gameObject;
        SetCurrent(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetCurrent(bool value)
    {
        if (_children != null)
        {
            _children.SetActive(value);
        }
    }

    void OnMouseDown()
    {
        if (_selectable)
        {
            _fight.UseSkill(this.gameObject);
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


    public GameCharacter character
    {
        get { return _character; }
        set { _character = value; }
    }
}
