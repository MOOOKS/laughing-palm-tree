using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class death : MonoBehaviour
{

    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        print("Triggered");
        if(other.tag == "Notes")
        {
            print("Death");
            player.GetComponent<onDeath>().Death();
        }
    }
}
