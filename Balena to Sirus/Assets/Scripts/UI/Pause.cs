using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using Unity.VisualScripting;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool gameIsPaused = false;
    private bool mainMenuOpen;
    public EventReference pausesound;
    public GameObject PauseUI;
    private snapshotmaster snapvalue;
    
    // Start is called before the first frame update
    void Start()
    {
        snapvalue = GameObject.Find("snapshotmasterrr").GetComponent<snapshotmaster>();
        PauseUI.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused == true)
            {
                  
                    Resume();
                    RuntimeManager.PlayOneShot(pausesound);
            }
            else
            {
               
                PauseGame();
                RuntimeManager.PlayOneShot(pausesound);
            }
        }

    }

    private void Resume()
    {
        snapvalue.IsGame();
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    
    private void PauseGame()
    {
        snapvalue.IsMenu(); 
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
