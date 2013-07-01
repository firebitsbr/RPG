using UnityEngine;
using System.Collections;

public class TimeCounter : MonoBehaviour {



    public GameObject counterBar;
    private GameCharacter _chararcter;

    private float _max;
    private Rect _size;
	
	void Start () {

        _size = this.gameObject.guiTexture.pixelInset;
        counterBar.guiTexture.pixelInset = _size;
        _max = _size.width;

	}

    public void Update()
    {
        if (_chararcter != null)
        {
            float percent = _chararcter.attributes.time - _chararcter.timer;
            _size.width = _max-(percent * _max / _chararcter.attributes.time);
            counterBar.guiTexture.pixelInset = _size;
        }
    }



    public GameCharacter chararcter
    {
        get { return _chararcter; }
        set { _chararcter = value; }
    }


    /***************************************************************************************************************/
}
