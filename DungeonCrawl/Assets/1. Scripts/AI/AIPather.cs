using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AIPather : MonoBehaviour
{
    public GameObject target;
    public Transform enemyLook;

    Seeker seeker;
    Path path;
    int currentWaypoint;


    public float speed = 10;
    float maxWaypointDistance = 2f;

    CharacterController characterController;

    void Start()
    {
        target = GameObject.Find("Player");
        seeker = GetComponent<Seeker>();
        seeker.StartPath(transform.position, target.transform.position, OnPathComplete);
        characterController = GetComponent<CharacterController>();
        
    }

    public void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
        else
        {
            Debug.Log(p.error);
        }
    }

    public void FixedUpdate()
    {
        if (path == null)
        {
            return;
        }
        if (currentWaypoint >= path.vectorPath.Count)
        {
            return;
        }
        seeker.StartPath(transform.position, target.transform.position, OnPathComplete);
        Vector3 dir = (path.vectorPath[currentWaypoint] - transform.position).normalized * speed;
        characterController.SimpleMove(dir);
        if (Vector3.Distance(transform.position, path.vectorPath[currentWaypoint]) < maxWaypointDistance )
        {
            currentWaypoint++;
        }
        
    }

    private void Update()
    {
        Vector3 tar = new Vector3(target.transform.position.x, enemyLook.position.y, target.transform.position.z);
        enemyLook.LookAt(tar);
    }


}
