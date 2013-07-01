using UnityEngine;
using System.Collections;

public class BoxAction : MonoBehaviour {

	// Use this for initialization

    private GameSkill[] _skills;
    private GameObject[] _buttons;

    public GameObject buttonAction;
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

    public void loadCharSkill(GameCharacter value, OptionType opt)
    {
        switch (opt)
        {
            case OptionType.Attack:


                break;
            case OptionType.Special:


                break;
            case OptionType.Item:


                break;
        }
    }

    public void addSkill(GameSkill skill)
    {

        Object obj = Instantiate(buttonAction);
        
        (obj as GameObject).transform.parent = this.transform;

        (obj as GameObject).GetComponent<GUIText>().pixelOffset = new Vector2(65, 115 + 54 * _count);

        _buttons.SetValue(obj, _count);
        _skills.SetValue(skill, _count);

        _count++;
    }

    public void resetItens()
    {
        _skills = new GameSkill[4];
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
