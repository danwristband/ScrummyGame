using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneP : MonoBehaviour
{
    public GameObject click, next;
    

    public void clickRequire()
    {
        SceneManager.LoadScene("Requiement");

    }
    public void EndRequire()
    {
        SceneManager.LoadScene("oneday");

    }

    public void clickDev()
    {
        SceneManager.LoadScene("Development");

    }
    public void EndDev()
    {
        SceneManager.LoadScene("End Sprint");

    }

    public void Clickdesign()
    {
        SceneManager.LoadScene("Design");

    }
    public void EndDesign()
    {
        SceneManager.LoadScene("oneday2");

    }

    public void ClickTest()
    {
        SceneManager.LoadScene("Testing");

    }
    public void EndTest()
    {
        SceneManager.LoadScene("Score");

    }

    public void nextskip()
    {
        next.SetActive(true);

    }

    void Start()
    {
        Invoke("nextskip", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
