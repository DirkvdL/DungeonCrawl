using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public int healthIndicator;
    protected int dealDamage ;
    public float enemyRange;
    public PlayerMove playerMove;
    public int dealDamToPlayer;
    public float enemydamtimer;
    float damtimer;
    protected bool isAttacking;

    private Lootdorp lootdorp;

    protected virtual void Start()
    {

        lootdorp = GameObject.Find("EnemiesParent").GetComponent<Lootdorp>();
        playerMove = GameObject.Find("Player").GetComponent<PlayerMove>();
        isAttacking = false;
    }

    protected virtual void Update()
    {
        dealDamage = Random.Range(10, 20);
        if (damtimer > 0)
        {
            damtimer -= Time.deltaTime;
        }
        Vector3 enemyPosition = transform.position;
        Vector3 playerPosition = GameObject.Find("Player").gameObject.transform.position;
        Vector3 diff = enemyPosition - playerPosition;
        float curDistance = diff.sqrMagnitude;
        if (curDistance <= enemyRange && damtimer <= 0)
        {
            DealDamageToPlayer();
        }
    }

    public virtual void DealDamage()
    {
        
        healthIndicator -= dealDamage;
        if (healthIndicator <= 0)
        {
            lootdorp.DropItem();
            Destroy(this.gameObject , 0.5f);           
            
            
        }
    }

    public void DealDamageToPlayer()
    {
        isAttacking = true;
        damtimer = enemydamtimer;
        playerMove.playerHealth -= dealDamToPlayer;
        
    }

    



}
