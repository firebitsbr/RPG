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

    private BoxCharController _boxChar;
    private BoxEnemiesController _boxEnemy;
    private ButtonActionController _boxActions;
    private BoxAction _boxAct;

    private bool _running;
    private ActionType _currentAction;
    private GameSkill _currentSkill;
    private GameItem _currentItem;
    private GameCharacter _currentTarget;

	void Start () {

        GlobalCharacter.Init();

        _boxChar = _charController.GetComponent<BoxCharController>();
        _boxEnemy = _enemiesController.GetComponent<BoxEnemiesController>();
        _boxActions = _buttonController.GetComponent<ButtonActionController>();
        _boxAct = _boxController.GetComponent<BoxAction>();

        _boxActions._character1.GetComponent<TimeCounter>().chararcter = GlobalCharacter.party[0];
        _boxActions._character2.GetComponent<TimeCounter>().chararcter = GlobalCharacter.party[1];
        _boxActions._character3.GetComponent<TimeCounter>().chararcter = GlobalCharacter.party[2];

        _running = true;

	}

    public void PauseTimer(bool value)
    {
        _running = value;
    }

    public void setIniciative()
    {

    }

    public void SetTargets(TargetTypes targets)
    {
        switch (targets)
        {
            case TargetTypes.Enemy:
                _boxEnemy.SetAllTarget();
                break;
            case TargetTypes.Party:
                _boxChar.SetAllTarget();
                break;
            case TargetTypes.Self:
                _boxChar.SetSelfTarget();
                break;
            case TargetTypes.OtherParty:
                _boxChar.SetOthersTarget();
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (_running)
        {
            _boxChar.UpdateTime();
            _boxEnemy.UpdateTime();

            GameCharacter _curr = _boxChar.GetCurrentReady();
            if (_curr != null && !_boxActions.buttonActive)
            {
                _boxAct.currentSelected = _curr;
                _boxActions.showButtons();
            }
        }
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
    public ButtonActionController boxActions
    {
        get { return _boxActions; }
        set { _boxActions = value; }
    }
    public BoxAction boxAct
    {
        get { return _boxAct; }
        set { _boxAct = value; }
    }


    public ActionType currentAction
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