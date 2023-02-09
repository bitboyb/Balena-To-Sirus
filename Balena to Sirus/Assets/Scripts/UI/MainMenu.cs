using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static bool mainMenu;
    private snapshotmaster snapvalue;
    public EventReference startsound;
    public GameObject gameUI;
    public GameObject mainMenuUI;
    public GameObject optionsMenuUI;
    public GameObject pauseUi;
    public GameObject pauseManager;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        snapvalue = GameObject.Find("snapshotmasterrr").GetComponent<snapshotmaster>();
        optionsMenuUI.SetActive(false);
        gameUI.SetActive(false);
        optionsMenuUI.SetActive(false);
        pauseUi.SetActive(false);
        pauseManager.SetActive(false);
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartGame()
    {
        snapvalue.IsGame();
        Time.timeScale = 1;
        mainMenuUI.SetActive(false);
        gameUI.SetActive(true);
        mainMenu = false;
        pauseManager.SetActive(true);
     
    }

    public void OptionsMenu()
    {
        snapvalue.IsMenu();
        mainMenuUI.SetActive(false);
        optionsMenuUI.SetActive(true);
        
    }

    public void CloseGame()
    {
       Application.Quit();
    }
}
