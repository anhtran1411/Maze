using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemPink : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource collectSound;
    private void OnTriggerEnter()
    {
        GlobalScore.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
    }




}
