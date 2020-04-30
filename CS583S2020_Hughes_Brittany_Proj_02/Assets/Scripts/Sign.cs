using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Sign : MonoBehaviour
{
    
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool inRange; 

    // Update is called once per frame
    void Update()
    {
        Debug.Log(inRange);
        Debug.Log(inRange);
        if(Input.GetKeyDown(KeyCode.X) && inRange)
        {
           
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                dialogBox.GetComponent<InputField>().text = dialog;
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true; 
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            inRange = false; 
            dialogBox.SetActive(false);
        }
    }
}
