/*
     * Darion Jeffries
     * PassThroughOnce
     * Challenge1
     * Bug fix, passes through triggers only once
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PassThroughOnce : MonoBehaviour
{
    private bool triggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }


}
