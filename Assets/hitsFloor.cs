using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitsFloor : MonoBehaviour
{
    public Image red;
    public Image blue;
    public Image yellow;
    public Image orange;
    public Image grey;
    public Image violet;
    public Image teel;
    public Image green;
    public Image black;
    public GameObject get;
    public GameObject get2;
    public Transform location;
    public Transform location2;
    public static int a = 0;
    public GameObject ball2;
    public GameObject cue2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag=="red")
            red.enabled = false;
        if(collision.gameObject.tag=="blue")
            blue.enabled = false;
        if(collision.gameObject.tag=="yellow")
            yellow.enabled = false;
        if(collision.gameObject.tag=="green")
            green.enabled = false;
        if(collision.gameObject.tag=="grey")
            grey.enabled = false;
        if(collision.gameObject.tag=="orange")
            orange.enabled = false;
        if(collision.gameObject.tag=="violet")
            violet.enabled = false;
        if(collision.gameObject.tag=="teel")
            teel.enabled = false;
        if(collision.gameObject.tag=="8ball")
            black.enabled = false;
        //if(collision.gameObject.tag=="cue"){
           // Instantiate(get,location.position, location.rotation);
           // Instantiate(get2,location2.position, location2.rotation);
       // }

    }

    void OnTriggerEnter(Collider collision){
        
        if(collision.gameObject.tag=="cue"){
            Destroy (stick.ball);
            Destroy (ball2);
            Destroy (cueFalls.got);
            ball2 = Instantiate(get,location.position, location.rotation);            
            cue2 = Instantiate(get2,location2.position, location2.rotation);
        }
    }
    
}
