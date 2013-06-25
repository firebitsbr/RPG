using UnityEngine;
using System.Collections;

public class WorldMapController : MonoBehaviour {


    public GameObject _location;
    private GameObject[] _locations;
    private GameObject _currentLocation;
    private Vector3 _point;

    public Vector2 _min;
    public Vector2 _max;

	void Start () {
	
	}

    void PanToLocation(GameObject value)
    {


    }

	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Down");
            _point = new Vector3(
                (float)(Input.mousePosition.x * 0.5 - this.transform.position.x),
                (float)(Input.mousePosition.y * 0.5 - this.transform.position.y),
                0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //Debug.Log("Up");
        }
        if(Input.GetMouseButton(0)) {

            Vector3 newPos = new Vector3(
                                    (float)((Input.mousePosition.x * 0.5 - _point.x)),
                                    (float)((Input.mousePosition.y * 0.5 - _point.y)), 
                                    0);
            if (newPos.x < _min.x)
            {
                newPos.x = _min.x;
            }
            if (newPos.x > _max.x)
            {
                newPos.x = _max.x;
            }
            if (newPos.y < _min.y)
            {
                newPos.y = _min.y;
            }
            if (newPos.y > _max.y)
            {
                newPos.y = _max.y;
            }
            this.transform.position = newPos;
        }
	}

    void AddPoint(WorldMapLocation location)
    {

    }
}
