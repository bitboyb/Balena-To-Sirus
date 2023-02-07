using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{

    public GameObject OptionsuUI;
    public GameObject MainMenuUI;
    public GameObject PauseUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackTo()
    {
        if (MainMenu.mainMenu == true)
        {
            MainMenuUI.SetActive(true);
            OptionsuUI.SetActive(false);
        }
        else
        {
            PauseUI.SetActive(true);
            OptionsuUI.SetActive(false);
        }
    }
}
