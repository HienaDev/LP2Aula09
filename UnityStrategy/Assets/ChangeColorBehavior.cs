using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorBehavior : MonoBehaviour, IColorBehavior
{


    private float redFactor;
    private float blueFactor;
    private float greenFactor;

    [SerializeField] private float redIncrement;
    [SerializeField] private float greenIncrement;
    [SerializeField] private float blueIncrement;


    public void ChangeColor()
    {
        redFactor += redIncrement * Time.deltaTime;
        greenFactor += greenIncrement * Time.deltaTime;
        blueFactor += blueIncrement * Time.deltaTime;

        GetComponent<MeshRenderer>().material.color = new Color(((Mathf.Sin(redFactor) + 1) / 2f), ((Mathf.Sin(greenFactor) + 1) / 2f), ((Mathf.Sin(blueFactor) + 1) / 2f));
    }
}
