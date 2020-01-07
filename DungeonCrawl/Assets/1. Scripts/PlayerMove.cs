using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float normalspeed = 0.0f;

    private Rigidbody player;

    private float horizontal;
    private float vertical;

    private void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * normalspeed * Time.deltaTime;
        vertical = Input.GetAxis("Vertical") * normalspeed * Time.deltaTime;
        transform.Translate(horizontal, 0, vertical);
    }
}
