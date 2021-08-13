using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialouge : MonoBehaviour
{
    public dialogueVariables[] diologue;

    Text diologueText;
    

    // Start is called before the first frame update
    void Start()
    {
        diologueText = GetComponent<Text>();
        StartCoroutine(diologueWrite());
        
    }

    

    IEnumerator diologueWrite()
    {
        int i = 0;
        while (i < diologue.Length)
        {  
            diologueText.text = diologue[i].dialogue;
            diologueText.fontSize = diologue[i].fontSize;
            diologueText.color = diologue[i].color;
            yield return new WaitForSeconds(diologue[i].timeDisplayed);
            i++;
        }
        endDiolouge();
    }

    void endDiolouge()
    {
        diologueText.text = " ";
        Debug.Log("dialogue ended");
        
    }
}
