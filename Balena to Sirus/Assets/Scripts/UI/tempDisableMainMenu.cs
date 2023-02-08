using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempDisableMainMenu : MonoBehaviour
{

    public GameObject mainMenuUI;
    
    // Start is called before the first frame update
    void Start()
    {
        mainMenuUI.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
