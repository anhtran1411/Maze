using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay;
    public bool isTakingTime = false;
    public int theSecond = 150;
    public static int extendScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        extendScore = theSecond;
        if(isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
        
    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSecond -= 1;
        timeDisplay.GetComponent<Text>().text = "" + theSecond;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }

}
