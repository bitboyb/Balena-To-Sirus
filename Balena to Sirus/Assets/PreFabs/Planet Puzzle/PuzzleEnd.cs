using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleEnd : MonoBehaviour
{
    public static bool pushedPlanet1;
    public static bool pushedPlanet2;
    public static bool pushedPlanet3;

    private Vector3 scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);

    private bool isScaling;


    public float shrinkTime = 1f;
    private float shrinkRate;

    public GameObject star;
    private Vector3 initialScale;
    
    // Start is called before the first frame update
    void Start()
    {
        shrinkRate = shrinkTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (pushedPlanet1 && pushedPlanet2 && pushedPlanet3)
        {
            star.transform.localScale += scaleChange;
            shrinkRate -= Time.timeScale;
        }

        if (shrinkRate < 0f)
        {
            Destroy(gameObject);
        }
    }


}
