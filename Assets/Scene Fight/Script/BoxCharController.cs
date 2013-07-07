using UnityEngine;
using System.Collections;

public class BoxCharController : MonoBehaviour {

    public GameObject _charModel;
    private GameObject charsFight;
    public GameCharacter _character;
    public Vector3 _positions = new Vector3(70, 10, 0);

    private int _current;

	void Start () {

        GlobalCharacter.Init();


        GlobalCharacter.player.timer = 0;

        ShowCharacter();
	}

    public void ShowCharacter()
    {
        AddCharToScene(_character);
    }
    private void AddCharToScene(GameCharacter value)
    {
        GameObject _itm = Instantiate(_charModel) as GameObject;
        _itm.transform.position = _positions;
        _itm.transform.parent = this.transform;
        _itm.GetComponent<CharFightController>().SetCurrent(false);
        _itm.GetComponent<CharFightController>().character = value;

        charsFight = _itm;
    }
	
	void Update () {
	
	}

    public void CancelAllTargets()
    {
        charsFight.GetComponent<CharFightController>().selectable = false;
    }

    public void SetSelfTarget()
    {
        charsFight.GetComponent<CharFightController>().selectable = true;
    }
}