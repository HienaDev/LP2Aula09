using UnityEngine;

public class NPC : MonoBehaviour
{
    private IAnimateBehaviour behaviour;
    private IColorBehavior colorBehavior;


    private void Awake()
    {
        behaviour = GetComponent<IAnimateBehaviour>();
        colorBehavior = GetComponent<IColorBehavior>();
    }

    // Update is called once per frame
    private void Update()
    {
        behaviour?.Animate();
        colorBehavior?.ChangeColor();
    }
}
