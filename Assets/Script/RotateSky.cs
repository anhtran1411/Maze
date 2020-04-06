using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float rotateSpped = 30.0f;
    void Update()
    {
        RenderSettings.skybox.SetFloat("Rotation", Time.deltaTime * rotateSpped);
    }
}
