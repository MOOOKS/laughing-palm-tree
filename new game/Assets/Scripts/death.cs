using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class death : MonoBehaviour
{

    public GameObject player;
    public Material material;

    void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Notes")
        {
            other.GetComponent<MeshRenderer>().material = material;
            player.GetComponent<onDeath>().Death();
        }
    }
}
