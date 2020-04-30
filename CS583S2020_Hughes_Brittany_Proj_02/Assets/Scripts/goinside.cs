using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class goinside : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool inRange;
    public string scene;

    void Update()
    {
        if (inRange)
        {
           dialogBox.SetActive(true);
           dialogBox.GetComponent<InputField>().text = dialog;
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(scene);

            }

        }

    }
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
            inRange = true;
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            inRange = false;
            dialogBox.SetActive(false);
        }
    }
}