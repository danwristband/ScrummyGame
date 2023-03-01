using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howtowalk : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("office");
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("next", 8f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
