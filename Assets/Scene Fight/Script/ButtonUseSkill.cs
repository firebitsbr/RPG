using UnityEngine;
using System.Collections;

public class ButtonUseSkill : MonoBehaviour {


    private GameSkill _skill;
    private GameItem _item;
    private ActionType _action;
    private FightController _fight;

	void Start () {
        _fight = GameObject.Find("Fight").GetComponent<FightController>();
	}
	
	
	void Update () {
	
	}

    void OnMouseDown()
    {
        _fight.boxAct.gameObject.SetActive(false);

        switch (_fight.currentAction)
        {
            case ActionType.GameItem:
                Debug.Log("use item:" + _item.name);

                _fight.SetTargets(_item.target);
                _fight.currentAction = _action;
                _fight.currentItem = _item;

                break;
            case ActionType.GameSkill:
                Debug.Log("use skill:" + _skill.name);

                _fight.SetTargets(_skill.target);
                _fight.currentAction = _action;
                _fight.currentSkill = _skill;

                break;
        }
    }





    public ActionType action
    {
        get { return _action; }
        set { _action = value; }
    }
    public GameSkill skill
    {
        get { return _skill; }
        set { _skill = value; }
    }
    public GameItem item
    {
        get { return _item; }
        set { _item = value; }
    }


    /**********************************************************************************************************************/
}
