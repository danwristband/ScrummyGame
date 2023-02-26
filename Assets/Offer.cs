using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Offer : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider Target)

    {

        if (Target.gameObject.tag == "Mission")

        {
            Debug.Log("tag");
            SceneManager.LoadScene("allrating");


        }
    }

            void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
