using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnemy : Enemies // INHERITANCE
{
    public override void Parameters() // POLYMORPHISM
    {
        heals = 100;
        maxHeals = 100;
        damageDeal = 2;
        text.text = heals.ToString() + "/" + maxHeals;
        slider.maxValue = maxHeals;
    }
}
