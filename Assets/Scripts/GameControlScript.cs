using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    public static int health;

    void Start()
    {
        health = 3;
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);
        gameOver.SetActive(false);
    }

    void Update()
    {
        if (health > 3) health = 3;

        switch(health)
        {
            case 3:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                break;
            case 2:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);
                break;
            case 1:
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;
            case 0:
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                gameOver.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    }
}
