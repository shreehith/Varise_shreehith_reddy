using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float movespeed = 10;
    public float leftrightspeed = 5;
    public bool isjumping = false;
    public bool comingdown = false;
    public GameObject playerobject;
   
    void Update()
    {
      transform.Translate(Vector3.forward * Time.deltaTime * movespeed , Space.World);  
      
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {   if (this.gameObject.transform.position.x > levelboundary.leftside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftrightspeed);
            }
            
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < levelboundary.rightside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * -1 * leftrightspeed);
            }
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.Space))
        {
            if(isjumping == false)
            {
                isjumping = true;
                playerobject.GetComponent<Animator>().Play("Jump");
                StartCoroutine(jumpsequence());
            }
        }
        if (isjumping==true)
        {
            if (comingdown==false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 5,Space.World);
            }
            if (comingdown ==true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -5, Space.World);
            }
        }

    }
    IEnumerator jumpsequence()
    {
        yield return new WaitForSeconds(0.5f);
        comingdown = true;
        yield return new WaitForSeconds(0.5f);
        isjumping = false;
        comingdown=false;
        playerobject.GetComponent<Animator>().Play("Standard Run");
    }
}
