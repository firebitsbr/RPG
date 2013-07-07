using UnityEngine;
using System.Collections;

public class FightController : MonoBehaviour {

	// add Character, add enemies
    // init timer
    // on player timer complete, show options
    // on enemy timer complete, 

    public GameObject _charController;
    public GameObject _enemiesController;
    public GameObject _buttonController;
    public GameObject _boxController;
    public GameObject _boxBattleDetail;

    public GameObject[] _buttons;
    public GameObject _charLife;
    public GameObject _charName;

    private BoxCharController _boxChar;
    private BoxEnemiesController _boxEnemy;
    private BoxAction _boxAct;

    private bool _running;
    private OptionType _currentAction;
    private GameSkill _currentSkill;
    private GameItem _currentItem;
    private GameCharacter _currentTarget;

	void Start () {

        GlobalCharacter.Init();

        _boxChar = _charController.GetComponent<BoxCharController>();
        _boxEnemy = _enemiesController.GetComponent<BoxEnemiesController>();
        _boxAct = _boxController.GetComponent<BoxAction>();

        _running = true;

        for (int i = 0; i < _buttons.Length; i++)
        {
            _buttons[i].GetComponent<ButtonAction>().character = GlobalCharacter.player;
            _buttons[i].GetComponent<ButtonAction>().fight = this;
        }

        HideText();
        UpdateAttributes();
	}

    public void UpdateAttributes()
    {
        int currLife = GlobalCharacter.player.attributes.life - GlobalCharacter.player.damageAttr.life;
        _charName.guiText.text = GlobalCharacter.player.name;
        _charLife.guiText.text = currLife + "/" + GlobalCharacter.player.attributes.life;
    }

    public void PauseTimer(bool value)
    {
        _running = value;
    }

    public void setIniciative()
    {

    }

    public void ResetButtonTimer()
    {
        for (int i = 0; i < _buttons.Length; i++)
        {
            _buttons[i].GetComponent<ButtonAction>().ready = false;
        }
    }

    public void UseSkill(GameObject target)
    {
        Debug.Log("click on target");
        switch (_currentAction)
        {
            case OptionType.Item:
                ShowText("Item used");
                break;
            case OptionType.Special:
                ShowText("Special used");
                break;
            case OptionType.Attack:
                ShowText("Attack");
                break;
            case OptionType.Defense:
                ShowText("Defense");
                break;
        }

        _boxChar.CancelAllTargets();
        ResetButtonTimer();

    }

    public void SetTargets(TargetTypes targets)
    {
        ShowText("Select your target");
        switch (targets)
        {
            case TargetTypes.Enemy:
                _boxEnemy.SetAllTarget();
                break;
            case TargetTypes.Self:
                _boxChar.SetSelfTarget();
                break;
            case TargetTypes.All:
                _boxChar.SetSelfTarget();
                _boxEnemy.SetAllTarget();
                break;
            case TargetTypes.AllEnemies:
                _boxEnemy.SetAllTarget();
                break;
            default:
                _boxChar.CancelAllTargets();
                _boxEnemy.CancelAllTargets();
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (_running)
        {
            _boxEnemy.UpdateTime();
        }
	}

    public void ShowText(string value)
    {
        _boxBattleDetail.guiText.text = value;
        _boxBattleDetail.SetActive(true);
    }
    public void HideText()
    {
        _boxBattleDetail.SetActive(false);
    }


    public GameObject boxBattleDetail
    {
        get { return _boxBattleDetail; }
        set { _boxBattleDetail = value; }
    }
    public BoxCharController boxChar
    {
        get { return _boxChar; }
        set { _boxChar = value; }
    }
    public BoxEnemiesController boxEnemy
    {
        get { return _boxEnemy; }
        set { _boxEnemy = value; }
    }
    public BoxAction boxAct
    {
        get { return _boxAct; }
        set { _boxAct = value; }
    }


    public OptionType currentAction
    {
        get { return _currentAction; }
        set { _currentAction = value; }
    }
    public GameSkill currentSkill
    {
        get { return _currentSkill; }
        set { _currentSkill = value; }
    }
    public GameItem currentItem
    {
        get { return _currentItem; }
        set { _currentItem = value; }
    }
    public GameCharacter currentTarget
    {
        get { return _currentTarget; }
        set { _currentTarget = value; }
    }
    /************************************************************************************************************/
}