using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehavior : MonoBehaviour, IAnimateBehaviour
{
    private float factor;

    [SerializeField] private float scaleFactor;
    [SerializeField] private float scaleIncrement;

    private void Awake()
    {
        factor = 0;
    }
    public void Animate()
    {
        factor += scaleIncrement * Time.deltaTime;
        gameObject.transform.localScale = Vector3.one * scaleFactor * (Mathf.Sin(factor) + 1.5f);
    }
}
