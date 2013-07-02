using UnityEngine;
using System.Collections;

public class BoxCharController : MonoBehaviour {

    public GameObject _charModel;
    private GameObject[] charsFight = new GameObject[3];
    public GameCharacter[] _character = new GameCharacter[3];
    public Vector3[] _positions = new Vector3[3] { new Vector3(70, 35, 0), new Vector3(70, 10, 0), new Vector3(70, -15, 0) };

    private ArrayList _order;
    private int _current;

	void Start () {
        _character = new GameCharacter[3];

        _character = GlobalCharacter.party;
        _character[0].timer = 0;
        _character[1].timer = 2;
        _character[2].timer = 4;

        _order = new ArrayList();

        ShowCharacter();
	}

    public void ShowCharacter()
    {
        for (int i = 0; i < _character.Length; i++)
        {
            if (_character[i] != null)
            {
                AddCharToScene(_character[i], i);
            }
        }

    }
    private void AddCharToScene(GameCharacter value, int pos)
    {
        GameObject _itm = Instantiate(_charModel) as GameObject;
        _itm.transform.position = _positions[pos];
        _itm.transform.parent = this.transform;
        _itm.GetComponent<CharFightController>().SetCurrent(false);

        charsFight[pos] = _itm;
    }
	
	void Update () {
	
	}

    public void CancelAllTargets()
    {
        for (int i = 0; i < charsFight.Length; i++)
        {
            if (charsFight[i] != null)
            {
                charsFight[i].GetComponent<CharFightController>().selectable = false;
            }
        }
    }

    public void SetAllTarget()
    {
        for (int i = 0; i < charsFight.Length; i++)
        {
            if (charsFight[i] != null)
            {
                charsFight[i].GetComponent<CharFightController>().selectable = true;
            }
        }
    }
    public void SetOthersTarget()
    {
        for (int i = 0; i < charsFight.Length; i++)
        {
            if (charsFight[i] != null && i != _current)
            {
                charsFight[i].GetComponent<CharFightController>().selectable = true;
            }
        }
    }
    public void SetSelfTarget()
    {

        if (charsFight[_current] != null)
        {
            charsFight[_current].GetComponent<CharFightController>().selectable = true;
        }
        
    }

    public void UpdateTime()
    {
        for (int i = 0; i < _character.Length; i++)
        {
            _character[i].UpdateTimer();
            if (_character[i].ready && _order.IndexOf(i) < 0)
            {
                _order.Add(i);
            }
        }
    }

    public void addCharacter(GameCharacter character, int num)
    {
        _character.SetValue(character, num);
    }

    public void removeCurrent()
    {
        for (int i = 0; i < charsFight.Length; i++)
        {
            if (charsFight[i] != null)
            {
                charsFight[i].GetComponent<CharFightController>().SetCurrent(false);
            }
        }
    }

    public GameCharacter GetCurrentReady()
    {
        if(_order.Count > 0) {
            int num = int.Parse(_order[0].ToString());
            if (_character[num].ready)
            {
                charsFight[num].GetComponent<CharFightController>().SetCurrent(true);
                _current = num;
                return _character[num];
            }
            else
            {
                _order.RemoveAt(0);
            }
        }
        return null;
    }



    public ArrayList order
    {
        get { return _order; }
        set { _order = value; }
    }
}