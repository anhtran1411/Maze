using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay;
    //public bool isTakingTime = false;
    //public int theSecond = 150;
    public static float extendScore;

    public GameObject gameOver;
    public GameObject LevelAudio;
    public GameObject faceOut;
   

    
    float startTime = 150f;

  
    void Start()
    {
        countDownTimer();
    }

    // Update is called once per frame
    void countDownTimer()
    {
        extendScore = startTime;
        if (startTime > 0)
        {

          
            TimeSpan spanTime = TimeSpan.FromSeconds(startTime);
            timeDisplay.GetComponent<Text>().text = spanTime.Minutes + " : " + spanTime.Seconds;
            startTime--;
            Invoke("countDownTimer", 1.0f);

        }
        else
        {
            StartCoroutine(GameOver());
        }
   
        }
    IEnumerator GameOver()
    {
        gameOver.SetActive(true);
        LevelAudio.SetActive(false);

        yield return new WaitForSeconds(2);
        faceOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }



}

