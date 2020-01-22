using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghoul : Enemies
{
    protected override void Start()
    {
        base.Start();
        healthIndicator = 10;
        dealDamToPlayer = 3;
        enemydamtimer = 1.3f;

    
    }
}
