using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public string nextArea;

    public void nextScene(string scene) { 
        SceneManager.LoadScene(scene);
      
    }
    public void Exit()
    {
        Debug.Log("APPLICATION HAS QUIT");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    // for the animation
    public void doNothing()
    {
        Debug.Log("Nothign");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene("Bedroom");
    }
    
    public void GameOver()
    {
        SceneManager.LoadScene("GAMEOVER");
        AudioListener.pause = true;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !collision.isTrigger)
        { 
            SceneManager.LoadScene(nextArea);

        }
        

    }
   

  
    /* public void Enable()
     {
         contextClue.SetActive(true);
     }
     public void Disable()
     {
         contextClue.SetActive(false);
     }
     */
}