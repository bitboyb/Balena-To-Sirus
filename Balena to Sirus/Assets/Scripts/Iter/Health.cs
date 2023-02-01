using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public static float health = 100;
    private float maxHealth = 100;

    public Text healthText;

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health:" + health.ToString();

        if (health >= maxHealth)
            health = maxHealth;

    }
}
