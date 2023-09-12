/*
     * Darion Jeffries
     * Target Pass Through
     * Prototype 1
     * Player loses game if falls off map.
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1
{
    public class PlayerLoseOnFall : MonoBehaviour
    {
        void Update()
        {
            if (transform.position.y < -10)
            {
                ScoreManager.gameOver = true;
            }

        }
    }
}
