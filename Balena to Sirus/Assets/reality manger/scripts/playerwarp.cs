using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwarp : MonoBehaviour
{
    public GameObject shadowplayer;
    public GameObject player;

    public void SwitchPlayer()
    {
        var playerPos = player.transform.position;
        var shadowPos = shadowplayer.transform.position;

        player.transform.position = shadowPos;
        shadowplayer.transform.position = playerPos;
    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            SwitchPlayer();
        }
    }
}
