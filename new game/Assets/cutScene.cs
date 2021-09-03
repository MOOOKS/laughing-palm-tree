using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cutScene : MonoBehaviour
{
    public cutsceneAnimationManager[] Manager;
    
    [HideInInspector]
    public moveScript move;
    
    
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine("playAnimations");
        }
    }

    IEnumerator playAnimations()
    {
        while (i < Manager.Length)
        {



            if(Manager[i].animationObject != null)
            {
                Manager[i].animationObject.Play();
            }
            if(Manager[i].ScriptFunction != null)
            {
                Manager[i].ScriptFunction.Invoke();
            }
            
            yield return new WaitForSeconds(Manager[i].waitForBeatsForNextEvent);
            i++;
        }
    }
}
