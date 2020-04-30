using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public static bool isPaused = false;
    public GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void LoadMenu()
    {
        Debug.Log("Loading Menu");
        SceneManager.LoadScene("TitleScreen");
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Debug.Log("APPLICATION HAS QUIT");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
    public void Resume()
    {
        Debug.Log("Resuming Game");
        AudioListener.pause = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        AudioListener.pause = true;
        Time.timeScale = 0f;
        isPaused = true;
    }
}

