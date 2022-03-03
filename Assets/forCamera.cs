using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forCamera : MonoBehaviour
{
    //public Camera cam1;
    //Vector3 pos;
    public Text text;
    public bool i = false;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    Vector3 pos;
 
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        //print(text.text);
    }

    // Update is called once per frame
    void Update()
    {
        //change texts
       if(Input.GetMouseButtonDown(1)){
           text.text = "View Mode";
           i = true;
           print(i);
           print(text.text);
       }else if(Input.GetMouseButtonDown(2)){
           i=false;
           print(i);
           text.text = "Stick Mode";
       }
    
    //for camera
    if(i==true){
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch,yaw,0.0f);

       if(Input.GetKey("i")){
                pos = transform.position;
                pos.z +=0.1f;
                transform.position = pos;
        }

            if(Input.GetKey("k")){
                pos = transform.position;
                pos.z -=0.1f;
                transform.position = pos;
        }

            if(Input.GetKey("l")){
                pos = transform.position;
                pos.x +=0.1f;
                transform.position = pos;
        }

            if(Input.GetKey("j")){
                pos = transform.position;
                pos.x -=0.1f;
                transform.position = pos;
        }
    }
        

    }
}
