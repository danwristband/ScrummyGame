using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howto2 : MonoBehaviour
{
    public void next1()
    {
        SceneManager.LoadScene("Minigame 2");
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("next1", 8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
