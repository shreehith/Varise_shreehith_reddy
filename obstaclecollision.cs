using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class obstaclecollision : MonoBehaviour
{
    public GameObject theplayer;
    public GameObject charmodel;
    public AudioSource crash;
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        crash.Play();
        theplayer.GetComponent<playermove>().enabled = false;
        charmodel.GetComponent<Animator>().Play("Stumble Backwards");
        StartCoroutine(quitgame());

    }  
    IEnumerator quitgame()
    {
        yield return new WaitForSeconds(2);
            EditorApplication.isPlaying = false;
        
    }
}
