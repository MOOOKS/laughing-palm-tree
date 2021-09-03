using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("back2menu", 13f);
    }

    void back2menu() {
        SceneManager.LoadScene(0);
}
}
