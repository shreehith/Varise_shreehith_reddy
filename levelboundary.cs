using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelboundary : MonoBehaviour
{
    public static float leftside = -3.5f;
    public static float rightside = 3.5f;
    public float internalleft;
    public float internalright;
    void Update()
    {
        internalleft = leftside;
        internalright = rightside;  
    }
}
