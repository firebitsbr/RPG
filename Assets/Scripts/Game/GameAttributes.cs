using UnityEngine;
using System.Collections;

public class GameAttributes {

	// Use this for initialization
    private int _agility;
    private int _technology;
    private int _alchemy;
    private int _endurance;
    private int _strength;

    private int _life;
    private int _mana;
    private int _time;
    private int _money;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetAttributes(int str, int agi, int end, int alc, int tec, int lif, int man, int tim, int mon)
    {
        
        _strength = str;
        _agility = agi;
        _endurance = end;
        _alchemy = alc;
        _technology = tec;
        _life = lif;
        _mana = man;
        _time = tim;
        _money = mon;

    }


    public int agility
    {
        get { return _agility; }
        set { _agility = value; }
    }
    public int technology
    {
        get { return _technology; }
        set { _technology = value; }
    }
    public int alchemy
    {
        get { return _alchemy; }
        set { _alchemy = value; }
    }
    public int endurance
    {
        get { return _endurance; }
        set { _endurance = value; }
    }
    public int strength
    {
        get { return _strength; }
        set { _strength = value; }
    }
    public int mana
    {
        get { return _mana; }
        set { _mana = value; }
    }
    public int life
    {
        get { return _life; }
        set { _life = value; }
    }
    public int time
    {
        get { return _time; }
        set { _time = value; }
    }
    public int money
    {
        get { return _money; }
        set { _money = value; }
    }
}
