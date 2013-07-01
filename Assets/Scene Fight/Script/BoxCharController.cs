using UnityEngine;
using System.Collections;

public class BoxCharController : MonoBehaviour {


    public GameCharacter[] _character;
    public Vector2[] _positions = new Vector2[3];

    private int[] _order;
    private int _current;

	void Start () {
        _character = new GameCharacter[3];
	}
	
	void Update () {
	
	}

    public void UpdateTime()
    {
        for (int i = 0; i < _character.Length; i++)
        {
            _character[i].UpdateTimer();
        }
    }


    public void addCharacter(GameCharacter character, int num)
    {
        _character.SetValue(character, num);
    }

    public GameCharacter GetCurrentReady()
    {
        for (int i = 0; i < 3; i++)
        {
            if (_character[_order[i]].ready)
            {
                return _character[_order[i]];
            }
        }
        return null;
    }



    public int[] order
    {
        get { return _order; }
        set { _order = value; }
    }
}