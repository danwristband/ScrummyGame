using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howto1 : MonoBehaviour
{
    public void next1()
    {
        SceneManager.LoadScene("minigame1");
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("next1", 14f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
