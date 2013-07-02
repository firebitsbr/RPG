using UnityEngine;
using System.Collections;

public class BoxAction : MonoBehaviour {

	// Use this for initialization

    private GameSkill[] _skills;
    private GameObject[] _buttons;

    public GameObject buttonAction;
    private int _count;

    private GameCharacter _currentSelected;

	void Start () {

        _skills = new GameSkill[4];
        _buttons = new GameObject[4];
        gameObject.SetActive(false);

        GameSkill _sk = new GameSkill();
        addSkill(_sk);
        addSkill(_sk);
        addSkill(_sk);
        addSkill(_sk);
	}

    public void loadCharSkill(OptionType opt)
    {
        _count = 0;
        removeItens();

        switch (opt)
        {
            case OptionType.Attack:

                for (int i = 0; i < 4; i++)
                {
                    if (_currentSelected.attacks[i] != null)
                    {
                        addSkill(_currentSelected.attacks[i]);
                    }
                }

                break;
            case OptionType.Special:

                for (int i = 0; i < 4; i++)
                {
                    if (_currentSelected.specials[i] != null)
                    {
                        addSkill(_currentSelected.specials[i]);
                    }
                }

                break;
            case OptionType.Item:

                for (int i = 0; i < 4; i++)
                {
                    if (_currentSelected.itens[i] != null)
                    {
                        addItem(_currentSelected.itens[i]);
                    }
                }

                break;
        }
    }

    public void addItem(GameItem itm)
    {



    }

    public void addSkill(GameSkill skill)
    {

        Object obj = Instantiate(buttonAction);
        
        (obj as GameObject).transform.parent = this.transform;

        (obj as GameObject).GetComponent<GUIText>().pixelOffset = new Vector2(65, 100 + 40 * _count);
        (obj as GameObject).GetComponent<GUIText>().text = skill.name;

        (obj as GameObject).GetComponent<ButtonUseSkill>().action = ActionType.GameSkill;
        (obj as GameObject).GetComponent<ButtonUseSkill>().skill = skill;

        _buttons.SetValue(obj, _count);
        _skills.SetValue(skill, _count);

        _count++;

    }

    public void removeItens()
    {
        for (int i = 0; i < 4; i++)
        {
            if (_buttons[i] != null)
            {
                Destroy(_buttons[i]);
            }
        }
    }

    public void resetItens()
    {
        _skills = new GameSkill[4];
    }

    public GameCharacter currentSelected
    {
        get { return _currentSelected; }
        set { _currentSelected = value; }
    }
}
