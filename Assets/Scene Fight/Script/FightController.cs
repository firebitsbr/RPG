using UnityEngine;
using System.Collections;

public class FightController : MonoBehaviour {

	// add Character, add enemies
    // init timer
    // on player timer complete, show options
    // on enemy timer complete, 

    public GameObject _charController;
    public GameObject _enemiesController;


    private bool _running;

	void Start () {

        // _charController.GetComponent<BoxCharController>().addCharacter();
        // _enemiesController.GetComponent<BoxEnemiesController>().addEnemy();

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


        }
	}
}