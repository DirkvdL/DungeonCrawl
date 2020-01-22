using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;
    public GameObject character;
    //public float clampAngle = 60f;

    private Vector2 mouseLook;
    private Vector2 smoothV;


    // Use this for initialization
    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));



        //Smooth maken van de camera door een tussenliggende waarde te pakken
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        //smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);

        mouseLook += smoothV;
        //mouseLook.y = Mathf.Clamp(mouseLook.y, -clampAngle, clampAngle);
        //Quaternion is voor smooth rotation
        //transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector2.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }
}
