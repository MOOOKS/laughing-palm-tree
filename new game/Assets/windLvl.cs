using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windLvl : MonoBehaviour
{
    public GameObject win;
    
    // Update is called once per frame
   

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            win.SetActive(true);
            FindObjectOfType<audioManager>().Play("Win");
        }
    }

}
