using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool gameIsPaused = false;
    private bool mainMenuOpen;
    
    public GameObject PauseUI;
    
    // Start is called before the first frame update
    void Start()
    {
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
            }
            else
            {
                    PauseGame();
            }
        }

    }

    private void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    
    private void PauseGame()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
