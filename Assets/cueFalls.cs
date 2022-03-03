using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cueFalls : MonoBehaviour
{
    public GameObject get;
    public Transform location;
    public GameObject get2; //might change
    public Transform location2; // might change
    public static GameObject got;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag=="cue" && getStick.ballstop == 1){
           // Destroy (instantiate.cue);
            print("not moving");
            
        }else if(collision.gameObject.tag=="cue" && getStick.ballstop == 0) {
            Destroy (got);
            Destroy (instantiate.cue);
            got = Instantiate(get2,new Vector3(getStick.qballx,getStick.qbally,getStick.qballz),Quaternion.identity);
            
            print("moving");
            //Instantiate(get,location.position, location.rotation);
            //Instantiate(get2,location2.position, location2.rotation);
        }
    }
}
