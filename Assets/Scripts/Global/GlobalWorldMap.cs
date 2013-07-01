using UnityEngine;
using System.Collections;

public class GlobalWorldMap {


    private static ArrayList _cities;

	static void Init() {
	
	}




    public ArrayList cities
    {
        get { return _cities; }
        set { _cities = value; }
    }
}
