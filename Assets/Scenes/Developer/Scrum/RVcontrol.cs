using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RVcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject i1,i2,i3,i4;
    public void im1()
    {
        i1.SetActive(true);
    }
    public void im2()
    {
        
        i2.SetActive(true);

    }
    public void im3()
    {
      
        i3.SetActive(true);
    }
    public void im4()
    {
       
        i4.SetActive(true);
    }



    void Start()
    {
        Invoke("im1", 3f);
        Invoke("im2", 5f);
        Invoke("im3", 7f);
        Invoke("im4", 9f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
