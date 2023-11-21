using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Superpower
{

    [SerializeField] private float damage;
    [SerializeField] private float heal;

    public override void Activate()
    {
        DealDamage(damage);
        Heal(heal);
    }
}
