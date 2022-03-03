using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{
     public Rigidbody rb;
     public GameObject get;
     public Transform location;
     public Transform location2;
     public GameObject get2;
     public static GameObject cue;
     public static GameObject white;
     


     

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>();
         
         if(rb.velocity == Vector3.zero){
            print("(start instance)Not Moving");
            //ballready = 1;
            //ballstop =1;
            //print(ballready);
            //Destroy (cue);
            //Destroy (white); 
           cue = Instantiate(get,location.position, location.rotation);
           white = Instantiate(get2,location2.position, location2.rotation);
           // Destroy (cue);
        }else{
            print("(start instance)Moving");
            //print(ballstop);
            //ballstop = 0;
            //Destroy (stick.ball);
            //Destroy (get);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(getStick.ballready == 1 && getStick.ballstop==1){
            print("(Update instance)Not Moving");
            //ballready = 1;
           // ballstop =1;
           // print(ballready);
            //Destroy (cue);
            //Destroy (white); 
             //cue = Instantiate(get,location.position, location.rotation);
            //white = Instantiate(get2,location2.position, location2.rotation);
           // Destroy (cue);
        }else{
            print("(update instance)Moving");
            //print(ballstop);
            //ballstop = 0;
            //Destroy (stick.ball);
            //Destroy (get);
        }

       // if(ballready == 1 && ballstop == 1)
            //white = Instantiate(get2,location2.position, location2.rotation);
     */
    }

    

    
}
