using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject TimeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCal;
    public int scoreCal;
    public int totalScoredd;

    void OnTriggerEnter()
    {
        timeCal = GlobalTimer.extendScore * 100;
        TimeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " x 100";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScoredd = GlobalScore.currentScore + timeCal;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScoredd;
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }
    IEnumerator CalculateScore()
    {
        TimeLeft.SetActive(true);
        yield return new WaitForSeconds(1);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(1);
    }
}
