using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject partPoint;
    


    
    

    void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "Cube")
        {
            
            gameObject.SetActive(false);
            partPoint.GetComponent<particle>().particleFunc();
            
            
        }
    }
}
