using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToMenu : MonoBehaviour
{
    public AudioSource buttonPress;
    public void MenuBack()
    {
        GlobalScore.currentScore =0;
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 1;
        SceneManager.LoadScene(0);
    }

   
}
