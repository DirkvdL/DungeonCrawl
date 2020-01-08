using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyInSight : MonoBehaviour
{
    public float fieldofViewAngle = 110f;
    public bool playerinsight;
    public Vector3 personalLastSighting;

    private NavMeshAgent nav;
    private SphereCollider col;
    private GameObject player;
    private Vector3 previousSight;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        col = GetComponent<SphereCollider>();

        
    }



}
