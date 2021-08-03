using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float track3 = 43;
    float track2 = 23;
    float track1 = 0;

    public bool isNotDead = true;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && isNotDead)
        {
            if(transform.position.x == track2)
            {
                transform.Translate(20, 0, 0);
            }
            if (transform.position.x == track1)
            {
                transform.Translate(23, 0, 0);
            }
        }else if(Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x == track2)
            {
                transform.Translate(-23, 0, 0);
            }
            if (transform.position.x == track3)
            {
                transform.Translate(-20, 0, 0);
            }
        }
    }

    
}
