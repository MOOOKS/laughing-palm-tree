using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject partPoint;
   
    void OnTriggerEnter(Collider other)
    {
        print("oook");
        if (other.name == "Cube")
        {
            print("yooo");
            gameObject.SetActive(false);
            partPoint.GetComponent<particle>().particleFunc();
        }
    }
}
