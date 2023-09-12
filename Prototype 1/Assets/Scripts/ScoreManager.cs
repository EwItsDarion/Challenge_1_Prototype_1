/*
     * Darion Jeffries
     * ScoreManager
     * Prototype 1
     * Manages score, win and lose behaviors.
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;

    public Text textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }
    void Update()
    {
        if(!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        if (score>=3)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if(won)
            {
                textbox.text = "You win!\nPress R to Try Again!";
            }
            else
            {
                textbox.text = "You lose!\nPress R to Try Again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}

    