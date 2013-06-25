using UnityEngine;
using System.Collections;

public class BoxAction : MonoBehaviour {

	// Use this for initialization

    private GameSkill[] _skills;
    private GameObject[] _buttons;

    public GUITexture buttonAction;
    private int _count;

	void Start () {

        _skills = new GameSkill[4];
        _buttons = new GameObject[4];
        //gameObject.SetActive(false);
        _count = 0;

        GameSkill _sk = new GameSkill();
        addSkill(_sk);
        addSkill(_sk);
        addSkill(_sk);
        addSkill(_sk);
	}

    public void addSkill(GameSkill skill)
    {

        Object obj = Instantiate(buttonAction);
        
        (obj as GameObject).transform.parent = this.transform;

        GUITexture text = ((obj as GameObject).GetComponent("GUITexture") as GUITexture);

        text.pixelInset = new Rect(10, 80 + 54 * _count, 44, 44);
        text.guiText.pixelOffset = new Vector2(65, 115 + 54 * _count);

        _buttons.SetValue(obj, _count);
        _skills.SetValue(skill, _count);

        _count++;

        updateSize();
    }
    public void updateSize()
    {
        (GetComponent("GUITexture") as GUITexture).pixelInset = new Rect(0, 75, 210, 54 * _count);
        gameObject.SetActive(true);
    }

    public void resetItens()
    {
        _skills = new GameSkill[4];
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
