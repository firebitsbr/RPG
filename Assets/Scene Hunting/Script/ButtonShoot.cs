using UnityEngine;
using System.Collections;

public class ButtonShoot : MonoBehaviour {

	// Use this for initialization

    private GameCharacter _character;
    private bool _ready;
    private OptionType _option;
    private float _timerCount;
    private Rect _size;
    private float _max;
    private bool _canCount;

    public GameObject counterBar;

	void Start () {
        _size = counterBar.guiTexture.pixelInset;
        _max = _size.width;
        _timerCount = 0;
        _ready = false;
	}

    void OnMouseUp()
    {
        _canCount = false;
    }

    void OnMouseDown()
    {
        _canCount = true;
    }

    void Update()
    {

        if (_canCount && !_ready)
        {
            int _time = 5;
            _timerCount += Time.deltaTime;

            //_time = GlobalCharacter.player.attributes.timeAttack;

            float percent = _time - _timerCount;
            _size.width = _max - (percent * _max / _time);
            //Debug.Log(_size.width);

            if (percent <= 0)
            {
                this.ready = true;
            }
        }
        else
        {
            _timerCount = 0;
            _size.width = 0;
            this.ready = false;
        }
        counterBar.guiTexture.pixelInset = _size;    
    }

    public bool ready
    {
        get { return _ready; }
        set { _ready = value; }
    }
}
