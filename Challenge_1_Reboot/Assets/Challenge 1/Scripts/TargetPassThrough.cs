/*
     * Darion Jeffries
     * Target Pass Through
     * Challenge1
     * When colliding with trigger, adds to score.
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TargetPassThrough : MonoBehaviour
{
    public Text textbox;

    private void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.score++;
        }
    }
}
