using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootdorp : MonoBehaviour
{
    public GameObject healthpot;
    private Transform epos;
    private int randnumber;

    private void Start()
    {
        epos = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }
    public void DropItem()
    {
        randnumber = Random.Range(0, 101);
        Debug.Log(randnumber);

        if (randnumber >= 75 && randnumber <= 95)
        {
            Instantiate(healthpot, epos.position, Quaternion.identity);
        }
        else if (randnumber < 75 && randnumber > 96)
        {
            return;
        }
        
    }
}
