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
    private int _money;

    private int _timeAttack;
    private int _timeSpecial;
    private int _timeItem;
    private int _timeDefense;

    public GameAttributes()
    {

    }
	
    public void SetTimers(int atk, int spe, int def, int itm)
    {
        _timeAttack = atk;
        _timeDefense = def;
        _timeItem = itm;
        _timeSpecial = spe;
    }

    public void SetAttributes(int str, int agi, int end, int alc, int tec, int lif, int mon)
    {
        
        _strength = str;
        _agility = agi;
        _endurance = end;
        _alchemy = alc;
        _technology = tec;
        _life = lif;
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
    public int life
    {
        get { return _life; }
        set { _life = value; }
    }
    public int timeAttack
    {
        get { return _timeAttack; }
        set { _timeAttack = value; }
    }
    public int timeDefense
    {
        get { return _timeDefense; }
        set { _timeDefense = value; }
    }
    public int timeItem
    {
        get { return _timeItem; }
        set { _timeItem = value; }
    }
    public int timeSpecial
    {
        get { return _timeSpecial; }
        set { _timeSpecial = value; }
    }
    public int money
    {
        get { return _money; }
        set { _money = value; }
    }
}
