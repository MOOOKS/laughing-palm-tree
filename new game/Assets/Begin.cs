using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    public void nextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
