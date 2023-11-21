using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepAI : AnimalsAI
{
    protected override void Move()
    {
        Debug.Log("Sheep moves");
    }

    protected override void TryEat()
    {
        Debug.Log("Sheep tries to eat");
    }

    protected override void TryReproduce()
    {
        Debug.Log("Sheep tries to reproduce");
    }

}
