using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderEnemy : Enemies
{

    public override void Parameters()
    {
        heals = 25;
        maxHeals = 25;
        damageDeal = 10;
        text.text = heals.ToString() + "/" + maxHeals;
        slider.maxValue = maxHeals;
    }

}
