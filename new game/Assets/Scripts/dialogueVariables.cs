using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class dialogueVariables 
{
    public float StartDelay;
    [TextArea(3, 10)]
    public string dialogue = "Write Text Here";
    public int fontSize = 30;
    public float timeDisplayed = 1;
    public float writeSpeed = 0.05f;
    public Color color;
    public string Audio;
    
}
