using UnityEngine;
using System.Collections;

public class ButtonAction : MonoBehaviour
{


    public bool _selected = false;
	
    public GameObject boxAction;
    public OptionType _option;
    public GameObject counterBar;

    private GameCharacter _character;
    private FightController _fight;
    private bool _ready;
    private float _timerCount;

    private float _max;
    private Rect _size;

	void Start () {
        _size = this.gameObject.guiTexture.pixelInset;
        counterBar.guiTexture.pixelInset = _size;
        _max = _size.width;
        _timerCount = 0;
	}
	
	void Update () {
        if (_character != null && !_ready)
        {
            int _time = 0;
            _timerCount += Time.deltaTime;
            switch (_option)
            {
                case OptionType.Attack:
                    _time = _character.attributes.timeAttack;
                    break;
                case OptionType.Special:
                    _time = _character.attributes.timeSpecial;
                    break;
                case OptionType.Defense:
                    _time = _character.attributes.timeDefense;
                    break;
                case OptionType.Item:
                    _time = _character.attributes.timeItem;
                    break;
            }

            float percent = _time - _timerCount;
            _size.width = _max - (percent * _max / _time);
            counterBar.guiTexture.pixelInset = _size;
            if (percent <= 0)
            {
                this.ready = true;
            }
        }
	}

    void OnMouseDown()
    {
        _fight.SetTargets(TargetTypes.Unknown);
        if (_ready)
        {
            SetSelected(!_selected);
        }
    }

    public void SetSelected(bool value)
    {
        switch (_option)
        {
            case OptionType.Attack:

                _fight.SetTargets(TargetTypes.Enemy);
                _fight.currentAction = _option;

                break;
            case OptionType.Defense:

                _fight.SetTargets(TargetTypes.Self);
                _fight.currentAction = _option;

                break;
            case OptionType.Item:
                    if (value)
                    {
                        boxAction.SetActive(true);
                        boxAction.GetComponent<BoxAction>().loadCharSkill(_option);
                        _selected = true;
                    }
                    else
                    {
                        boxAction.SetActive(false);
                        _selected = false;
                    }
                break;
            case OptionType.Special:
                    if (value)
                    {
                        boxAction.SetActive(true);
                        boxAction.GetComponent<BoxAction>().loadCharSkill(_option);
                        _selected = true;
                    }
                    else
                    {
                        boxAction.SetActive(false);
                        _selected = false;
                    }
                break;
        }
    }


    public bool ready
    {
        get { return _ready; }
        set { 
            _ready = value;
            if (_ready)
            {
                counterBar.SetActive(false);
                this.guiTexture.color = new Color(0, 0.5f, 0, 0.5f);
                _timerCount = 0;
            }
            else
            {
                _timerCount = 0;
                counterBar.SetActive(true);
                this.guiTexture.color = Color.gray;
            }
        }
    }

    public void VerifySkillsAvaliable()
    {
        int tot = 0;
        switch (_option)
        {
            case OptionType.Special:
                for (int i = 0; i < _character.specials.Length; i++)
                {
                    if (_character.specials[i] != null)
                    {
                        tot++;
                    }
                }
                if (tot == 0)
                {
                    this.gameObject.SetActive(false);
                }
                break;
            case OptionType.Item:
                for (int i = 0; i < _character.itens.Length; i++)
                {
                    if (_character.itens[i] != null)
                    {
                        tot++;
                    }
                }
                if (tot == 0)
                {
                    this.gameObject.SetActive(false);
                }
                break;
        }
    }

    public FightController fight
    {
        get { return _fight; }
        set { _fight = value; }
    }
    public GameCharacter character
    {
        get { return _character; }
        set { 
            _character = value;
            VerifySkillsAvaliable();
        }
    }
}
