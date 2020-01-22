using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public int speed;
    public int rotationspeed;
    void Update()
    {
        //if (Input.GetKey("w"))
        //{
        //    Vector3 position = this.transform.position;
        //    position.z++;
        //    this.transform.position = position;
        //}
        //if (Input.GetKey("s"))
        //{
        //    Vector3 position = this.transform.position;
        //    position.z--;
        //    this.transform.position = position;
        //}
        //if (Input.GetKey("d"))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x++;
        //    this.transform.position = position;
        //}
        //if (Input.GetKey("a"))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x--;
        //    this.transform.position = position;
        //}

        transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Rotate (0, Input.GetAxis("Horizontal") * rotationspeed * Time.deltaTime, 0);
    }
}
