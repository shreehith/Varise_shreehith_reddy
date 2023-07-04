using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class leveldistance : MonoBehaviour
{
    public GameObject disdispaly;
    public int disrun;
    public bool addingdis = false;

    
    void Update()
    {
     if (addingdis==false)
        {
            addingdis = true;
            StartCoroutine(Addingdis());
        }
    }
    IEnumerator Addingdis()
    {
        disrun += 1;
        disdispaly.GetComponent<TextMeshPro>().text = "" + disrun;
        yield return new WaitForSeconds(0.25f);
        addingdis=false;
        
    }
}
