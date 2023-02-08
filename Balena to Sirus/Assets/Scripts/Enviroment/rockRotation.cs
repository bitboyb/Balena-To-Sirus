using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Random.Range(1,360),Random.Range(1,360),Random.Range(1,360));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
