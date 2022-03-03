using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollbar : MonoBehaviour
{
    public float ss;
    public float pp;
    // Start is called before the first frame update
    void Start()
    {   
        ss = GetComponent<Scrollbar>().size;
        transform.GetComponent<Scrollbar>().size = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {   
        if(ss >= 1){
            ss=0;
            pp=0;
        }else if(ss <= 1){
            ss+=0.001f;
            pp +=0.05f;
            transform.GetComponent<Scrollbar>().size = ss;
            stick.ballspeed = pp;        
        }
        
        
    }
}
