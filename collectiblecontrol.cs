
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class collectiblecontrol : MonoBehaviour
{
    public static int coincount=0;
    public GameObject coincountdisplay;

    
    void Update()
    {
       coincountdisplay.GetComponent<TextMeshPro>().text = "" + coincount;
    }
}
