using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehavior : MonoBehaviour, IAnimateBehaviour
{
    private float factor;

    private void Awake()
    {
        factor = 0;
    }
    public void Animate()
    {
        factor += 10 * Time.deltaTime;
        gameObject.transform.localScale = Vector3.one * (Mathf.Sin(factor) + 1.5f);
    }
}
