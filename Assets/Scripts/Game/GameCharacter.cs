using UnityEngine;
using System.Collections;

public class GameCharacter : MonoBehaviour {


    private GameItem _leftLeg;
    private GameItem _rightLeg;
    private GameItem _leftArm;
    private GameItem _rightArm;
    private GameAttributes _attributes;
    private GameItem[] _itens = new GameItem[4];

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}




    public GameItem[] itens
    {
        get { return _itens; }
        set { _itens = value; }
    }
    public GameAttributes attributes
    {
        get { return _attributes; }
        set { _attributes = value; }
    }
    public GameItem leftLeg
    {
        get { return _leftLeg; }
        set { _leftLeg = value; }
    }
    public GameItem rightLeg
    {
        get { return _rightLeg; }
        set { _rightLeg = value; }
    }
    public GameItem leftArm
    {
        get { return _leftArm; }
        set { _leftArm = value; }
    }
    public GameItem rightArm
    {
        get { return _rightArm; }
        set { _rightArm = value; }
    }
    /**********************************************************************************************/
}
