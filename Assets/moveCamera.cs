using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
     public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch,yaw,0.0f);

        if(Input.GetKey("l")){
                pos = transform.position;
                pos.z +=0.1f;
                transform.position = pos;
        }

            if(Input.GetKey("j")){
                pos = transform.position;
                pos.z -=0.1f;
                transform.position = pos;
        }

            if(Input.GetKey("i")){
                pos = transform.position;
                pos.x +=0.1f;
                transform.position = pos;
        }

            if(Input.GetKey("k")){
                pos = transform.position;
                pos.x -=0.1f;
                transform.position = pos;
        }
    }
}
