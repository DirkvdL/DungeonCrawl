using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    Ray enemyRay;
    public Color rayColor;
    RaycastHit rayHit;
    bool follow;

    private NavMeshAgent agent;
    public Transform getHim;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        enemyRay = new Ray(transform.position, -transform.position * 10);
        Debug.DrawRay(transform.position, -transform.position * 10, rayColor);

        if (Physics.Raycast(transform.position, -transform.position, 10))
        {
            follow = true;
        }

        if (follow == true)
        {
            transform.LookAt(getHim);
            transform.Translate(Vector3.forward *Time.deltaTime); 
        }
    }

}
