using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashPower : Superpower
{

    [SerializeField] private float speedPercent;

    public override void Activate()
    {
        LightMyFire();
        BoostSpeed(speedPercent);
    }


}
