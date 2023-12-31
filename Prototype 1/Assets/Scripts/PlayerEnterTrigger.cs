﻿/*
     * Darion Jeffries
     * PlayerEnterTrigger
     * Prototype 1
     * When colliding with trigger, adds to score.
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Trigger"))
        {
            ScoreManager.score++;
        }
    }
}
