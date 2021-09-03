using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class demoDoneScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("demoDone", 28f);
    }

   void demoDone()
    {
        SceneManager.LoadScene(6);
    }
}
