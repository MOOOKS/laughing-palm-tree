using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class onDeath : MonoBehaviour
{
    
    public move player;
    public GameObject pl;
    public GameObject gameOverScreen;
    public void Death()
    {
        FindObjectOfType<audioManager>().Play("playerDeath");
        FindObjectOfType<audioManager>().StopPlaying("Song");
        StartCoroutine(InvokeRealtimeCoroutine(deathAnimationPlay, 1f));



        Time.timeScale = 0f;
        player.isNotDead = false;
        



    }
    public void Destroy()
    {
        resetLevel();
        
        
    }

    void resetLevel()
    {
        Time.timeScale = 1f;
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void deathAnimationPlay()
    {
        gameOverScreen.SetActive(true);
        FindObjectOfType<audioManager>().Play("gameOver");
    }
    private IEnumerator InvokeRealtimeCoroutine(UnityAction action, float seconds)
    {
        yield return new WaitForSecondsRealtime(seconds);
        if (action != null)
            action();
    }



}
