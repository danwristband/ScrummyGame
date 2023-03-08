using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class knowcontrol : MonoBehaviour
{
    public GameObject next; 
    // Start is called before the first frame update

    public void nextapp()
    {
        next.SetActive(true);
    }

    public void premini1()
    {
        SceneManager.LoadScene("Howto 1");
    }
    public void mini1()
    {
        SceneManager.LoadScene("Score");
    }
    public void mini2()
    {
        SceneManager.LoadScene("Score");
    }
    public void mini3()
    {
        SceneManager.LoadScene("Score");
    }
    public void mini4()
    {
        SceneManager.LoadScene("Score");
    }
    public void mini5()
    {
        SceneManager.LoadScene("Sprint234");
    }

    void Start()
    {
        Invoke("next", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
