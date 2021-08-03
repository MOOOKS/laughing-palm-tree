
using UnityEngine;
using UnityEngine.SceneManagement;

public class onDeath : MonoBehaviour
{
    public Animator anim;
    public move player;
    public GameObject pl;
    public void Death()
    {
        anim.enabled = true;
        Time.timeScale = .2f;
        player.isNotDead = false;
        



    }
    public void Destroy()
    {
        resetLevel();
        
        
    }

    void resetLevel()
    {
        Time.timeScale = 1f;
        print("reset");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
