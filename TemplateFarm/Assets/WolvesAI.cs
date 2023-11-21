

using UnityEngine;

public class WolvesAI : AnimalsAI
{

    protected override void SelectTarget()
    {
        Debug.Log("Wolf selects target");
    }

    protected override void Move()
    {
        Debug.Log("Wolf moves");
    }

    protected override void TryEat()
    {
        Debug.Log("Wolf tries to eat");
    }

    protected override void TryReproduce()
    {
        Debug.Log("Wolf tries to reproduce");
    }

}
