using UnityEngine;
using System.Collections;

public class BoxEnemiesController : MonoBehaviour {

    public GameObject _charModel;
    private GameObject[] charsFight = new GameObject[5];
    public GameCharacter[] _character = new GameCharacter[5];
    public Vector3[] _positions = new Vector3[5] { 
                                    new Vector3(-75, 35, 0), 
                                    new Vector3(-75, 10, 0), 
                                    new Vector3(-75, -15, 0),
                                    new Vector3(-50, 22, 0),
                                    new Vector3(-50, -2, 0)
                                    };

    private ArrayList _order;


    void Start()
    {
        _character = new GameCharacter[5];

        for (int i = 0; i < 5; i++)
        {
            _character[i] = GlobalCharacter.enemies[i] as GameCharacter;
            _character[i].timer = i;
        }
        

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
        _itm.GetComponent<CharFightController>().character = value;

        charsFight[pos] = _itm;
    }

    void Update()
    {

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

    public void UpdateTime()
    {
        for (int i = 0; i < _character.Length; i++)
        {
            //_character[i].UpdateTimer();
            if (_character[i].ready && _order.IndexOf(i) < 0)
            {
                //charsFight[i].GetComponent<CharFightController>().SetCurrent(true);
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
        if (_order.Count > 0)
        {
            int num = int.Parse(_order[0].ToString());
            if (_character[num].ready)
            {
                charsFight[num].GetComponent<CharFightController>().SetCurrent(true);
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
