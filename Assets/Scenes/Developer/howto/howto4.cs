using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howto4 : MonoBehaviour
{
    public void next1()
    {
        SceneManager.LoadScene("mini4");
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("next1", 30f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
