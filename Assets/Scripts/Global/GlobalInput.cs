using UnityEngine;
using System.Collections;

public class GlobalInput {

    private static bool _hasInit = false;
    private static InputType _type;

    public static void Init()
    {
        if (!_hasInit)
        {
            

            _hasInit = true;
        }
    }
    public static bool verifyInput(InputType type) {
        return type == _type;
    }



    public static InputType type
    {
        get { return _type; }
        set { _type = value; }
    }
}