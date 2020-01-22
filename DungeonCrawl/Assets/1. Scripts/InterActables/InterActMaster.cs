using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterActMaster : MonoBehaviour
{
    public PlayerMove player;
    public int healthAdd;

    protected virtual void Start()
    {
        player = FindObjectOfType<PlayerMove>();
    }
    private void OnTriggerEnter(Collider other)
    {
        player.playerHealth += healthAdd;
        Destroy(this.gameObject);       
    }
}
