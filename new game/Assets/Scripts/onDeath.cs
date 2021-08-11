
using UnityEngine;
using UnityEngine.SceneManagement;

public class onDeath : MonoBehaviour
{
    
    public move player;
    public GameObject pl;
    public void Death()
    {
        FindObjectOfType<audioManager>().Play("playerDeath");
        FindObjectOfType<audioManager>().StopPlaying("Song");
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

    
}
