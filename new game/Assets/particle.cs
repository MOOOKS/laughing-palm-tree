using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
     public GameObject partCool;
     public Transform partPoint;
    public void particleFunc()
    {
        
        GameObject part = Instantiate(partCool, partPoint.position, Quaternion.identity);
        Destroy(part, 1f);
    }
}


