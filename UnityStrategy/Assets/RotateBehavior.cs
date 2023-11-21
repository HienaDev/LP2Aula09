using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehavior : MonoBehaviour, IAnimateBehaviour
{

    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;



    public void Animate()
    { 
        gameObject.transform.Rotate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
    }
}
