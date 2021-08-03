using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource aud;
    // Start is called before the first frame update
    

    void playSong()
    {
        aud.Play();
    }
    void Start()
    {
        Invoke("playSong", 3f);
    }
}
