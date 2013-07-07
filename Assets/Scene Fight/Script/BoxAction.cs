using UnityEngine;
using System.Collections;

public class BoxAction : MonoBehaviour {

	// Use this for initialization

    private GameSkill[] _skills;
    private GameItem[] _itens;
    private GameObject[] _buttons;

    public GameObject buttonAction;
    private int _count;

    private FightController _fight;

	void Start () {

        _skills = new GameSkill[4];
        _itens = new GameItem[4];
        _buttons = new GameObject[4];
        gameObject.SetActive(false);

        _fight = Camera.main.GetComponent<FightController>();

	}

    public void loadCharSkill(OptionType opt)
    {
        _count = 0;
        removeItens();

        switch (opt)
        {
            case OptionType.Special:

                for (int i = 0; i < 4; i++)
                {
                    if (GlobalCharacter.player.specials[i] != null)
                    {
                        addSkill(GlobalCharacter.player.specials[i]);
                    }
                }

                break;
            case OptionType.Item:

                for (int i = 0; i < 4; i++)
                {
                    if (GlobalCharacter.player.itens[i] != null)
                    {
                        addItem(GlobalCharacter.player.itens[i]);
                    }
                }

                break;
        }
        this.guiTexture.pixelInset = new Rect(135, 60, 220, _count * 40);
        _fight.currentAction = opt;
    }

    public void addItem(GameItem itm)
    {

        Object obj = Instantiate(buttonAction);

        (obj as GameObject).transform.parent = this.transform;

        (obj as GameObject).GetComponent<GUIText>().pixelOffset = new Vector2(210, 80 + 40 * _count);
        (obj as GameObject).GetComponent<GUIText>().text = itm.name;

        (obj as GameObject).GetComponent<ButtonUseSkill>().action = OptionType.Item;
        (obj as GameObject).GetComponent<ButtonUseSkill>().item = itm;

        _buttons.SetValue(obj, _count);
        _itens.SetValue(itm, _count);

        _count++;

    }

    public void addSkill(GameSkill skill)
    {

        Object obj = Instantiate(buttonAction);
        
        (obj as GameObject).transform.parent = this.transform;

        (obj as GameObject).GetComponent<GUIText>().pixelOffset = new Vector2(210, 80 + 40 * _count);
        (obj as GameObject).GetComponent<GUIText>().text = skill.name;

        (obj as GameObject).GetComponent<ButtonUseSkill>().action = OptionType.Special;
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
        _itens = new GameItem[4];
    }
}
