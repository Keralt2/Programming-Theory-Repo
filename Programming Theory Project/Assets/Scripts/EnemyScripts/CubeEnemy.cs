using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnemy : Enemies
{
    public override void Parameters()
    {
        heals = 120;
        maxHeals = 120;
        damage = 20;
        text.text = heals.ToString() + "/" + maxHeals;
    }
}
