/*
     * Darion Jeffries
     * TriggerBugFix
     * Prototype 1
     * When colliding with trigger, adds to score once.
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBugFix : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
    
}
