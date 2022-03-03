using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : MonoBehaviour
{
    
    // Start is called before the first frame update
    Vector3 tempPos;
 	public Rigidbody rb;
    public GameObject ballPrefab;
    public GameObject dd;
    public Transform ballspawn;
    public static float ballspeed = 0;
    public static GameObject ball;
    //public static GameObject stk;
    
    

    void Start()
    {
        GetComponent<ConstantForce>().enabled = false;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonUp("Fire1")){
            fire();

        }

        if(Input.GetKey("up")){
            tempPos = transform.position;
            tempPos.z +=0.1f;
            transform.position = tempPos;
        }

        if(Input.GetKey("down")){
            tempPos = transform.position;
            tempPos.z -=0.1f;
            transform.position = tempPos;
        }

        if(Input.GetKey("right")){
            tempPos = transform.position;
            tempPos.x +=0.1f;
            transform.position = tempPos;
        }

        if(Input.GetKey("left")){
            tempPos = transform.position;
            tempPos.x -=0.1f;
            transform.position = tempPos;
        }
    }
   

    private void fire(){
        ball = Instantiate(ballPrefab);
        Physics.IgnoreCollision(ball.GetComponent<Collider>(),ballspawn.parent.GetComponent<Collider>());
        ball.transform.position = ballspawn.position;
        Vector3 rotation = ball.transform.rotation.eulerAngles;
        ball.transform.rotation = Quaternion.Euler(rotation.x,transform.eulerAngles.y,rotation.z);
        ball.GetComponent<Rigidbody>().AddForce(ballspawn.forward * ballspeed,ForceMode.Impulse);
         Destroy (gameObject);
         Destroy (instantiate.white);
         Destroy (instantiate.cue);
         
    }
}
