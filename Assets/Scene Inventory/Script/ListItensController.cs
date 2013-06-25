using UnityEngine;
using System.Collections;

public class ListItensController : MonoBehaviour {

	// Use this for initialization
    public GameObject item;

	void Start () {

        for (int i = 0; i < 15; i++)
        {
            switch (i % 3)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
            }
        }
	}

    // Update is called once per frame
    void Update()
    {
	
	}
}
