using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    public string parentname;

    // Update is called once per frame
    void Start()
    {
        parentname = transform.name;
        StartCoroutine(destroyclone());

    }
    IEnumerator destroyclone()
    {
        yield return new WaitForSeconds(10);
        if (parentname == "section(Clone)")
        {
            Destroy(gameObject);    
        }
    }
}
