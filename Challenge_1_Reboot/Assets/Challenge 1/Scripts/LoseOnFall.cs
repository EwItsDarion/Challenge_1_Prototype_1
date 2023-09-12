/*
     * Darion Jeffries
     * LoseOnFall
     * Challenge1
     * If player goes above x value or below y value, game over
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype1
{
    public class LoseOnFall : MonoBehaviour
    {

        public Text textbox;


        // Update is called once per frame
        void Update()
        {
            if (transform.position.y < -51 || transform.position.y > 80)
            {
                ScoreManager.gameOver = true;
            }

        }
    }
}