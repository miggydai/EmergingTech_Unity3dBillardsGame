using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getStick : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject get;
     public Transform location;
     public static int ballstop = 1;
     public static int ballready = 0;
     public static float qballx;
     public static float qbally;
     public static float qballz; 
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>();
         
         if(rb.velocity == Vector3.zero){
            print("(the ball)Not Moving");
         }else{
             print("(The ball)Moving");
         }
    }

    // Update is called once per frame
    void Update()
    {
         if(rb.velocity == Vector3.zero){
           // print("(Update gstick)Not Moving");
            ballready = 1;
            ballstop = 1;
            //print(ballstop);
            //Destroy (cue);
            //Destroy (white); 
            //cue = Instantiate(get,location.position, location.rotation);
            //white = Instantiate(get2,location2.position, location2.rotation);
           // Destroy (cue);
        }else{
            //print("(update gstick)Moving");
            //print(ballstop);
            qballx = transform.position.x;
            qbally = transform.position.y;
            qballz = transform.position.z;
            ballstop = 0;
            //Destroy (stick.ball);
            //Destroy (get);
        }
    }
}
