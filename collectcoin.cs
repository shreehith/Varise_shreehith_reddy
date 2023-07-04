using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcoin : MonoBehaviour
{
    public AudioSource coinfx;
    private void OnTriggerEnter(Collider other)
    {
        coinfx.Play();
        collectiblecontrol.coincount += 1;
        this.gameObject.SetActive(false);
    }
}
