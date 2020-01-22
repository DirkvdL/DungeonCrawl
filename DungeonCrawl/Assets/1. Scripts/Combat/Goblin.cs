using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemies
{
    private Animator goblinAnim;

    protected override void Start()
    {
        base.Start();
        goblinAnim = GetComponentInChildren<Animator>();
        int healthgoblin = Random.Range(25, 35);
        int dealDam = Random.Range(10, 15);
        healthIndicator = healthgoblin;
        dealDamToPlayer = dealDam;
        enemydamtimer = 2.3f;

    }

    protected override void Update()
    {
        base.Update();
        
        if (isAttacking == true)
        {
            Debug.Log("joe");
            goblinAnim.SetBool("isAttacking", true);
            Debug.Log("joe");
        }
        else
        {
            goblinAnim.SetBool("isAttacking", false);
        }
    }
}
