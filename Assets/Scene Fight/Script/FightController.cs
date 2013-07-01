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

	void Start () {

        _boxChar = _charController.GetComponent<BoxCharController>();
        _boxEnemy = _enemiesController.GetComponent<BoxEnemiesController>();
        _boxActions = _buttonController.GetComponent<ButtonActionController>();
        _boxAct = _boxController.GetComponent<BoxAction>();

        _running = false;
	}

    public void PauseTimer(bool value)
    {
        _running = value;
    }

    public void setIniciative()
    {

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
            }
        }
	}
}