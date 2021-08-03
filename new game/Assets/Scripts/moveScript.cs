using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    public float beat = 100;
    // Start is called before the first frame update
    void Start()
    {
        beat = beat / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, beat * Time.deltaTime);
    }

   
}
