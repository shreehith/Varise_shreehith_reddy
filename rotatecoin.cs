using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecoin : MonoBehaviour
{
    public int rotatespeed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatespeed, 0, Space.World);
    }
}
