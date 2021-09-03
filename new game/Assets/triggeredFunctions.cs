using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggeredFunctions : MonoBehaviour
{
    public GameObject Black;
    //Lighting
    public void FogLightingOFff()
    {
        RenderSettings.fog = false;
        GameObject.Find("Directional Light").GetComponent<Light>().color = new Color(0, 0, 0);
    }

    //UI
    public void turnToBlack()
    {
        Black.SetActive(true);
    }
}
