using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialouge : MonoBehaviour
{
    public dialogueVariables[] diologue;

    Text diologueText;
    audioManager Audio;
    
    int i = 0;


    // Start is called before the first frame update
    void Start()
    {
        Audio = FindObjectOfType<audioManager>();
        diologueText = GetComponent<Text>();
        StartCoroutine(diologueWrite());
        
    }

    

    

    IEnumerator diologueWrite()
    {
        
        while (i < diologue.Length)
        {
            yield return new WaitForSeconds(diologue[i].StartDelay);
            StopCoroutine(typeAnim());
            StartCoroutine(typeAnim());
            //diologueText.text = diologue[i].dialogue;
            diologueText.fontSize = diologue[i].fontSize;
            diologueText.color = diologue[i].color;
            yield return new WaitForSeconds(diologue[i].timeDisplayed);
            i++;
        }
        endDiolouge();
    }
    IEnumerator typeAnim()
    {
        diologueText.text = "";
        
        
            foreach (char letter in diologue[i].dialogue.ToCharArray())
            {
                diologueText.text += letter;

            
              
                Audio.Play(diologue[i].Audio);
            
            
                
                yield return new WaitForSeconds(diologue[i].writeSpeed);
            }
        
        
        
    }

    void endDiolouge()
    {
        diologueText.text = " ";
        Debug.Log("dialogue ended");
        
    }
}
