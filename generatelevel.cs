using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatelevel : MonoBehaviour
{
    public GameObject[] section;
    public int zpos = 50;
    public bool createsection = false;
    public int secnum;
    void Update()
    {
       if (createsection==false)
        {
            createsection = true;
            StartCoroutine(generatesection());
        }
    }
    IEnumerator generatesection()
    {
        secnum = Random.Range(0, 3);
        Instantiate(section[secnum],new Vector3(0,0,zpos), Quaternion.identity);
        zpos = zpos + 50;
        yield return new WaitForSeconds(5);
        createsection = false;
    }
}
