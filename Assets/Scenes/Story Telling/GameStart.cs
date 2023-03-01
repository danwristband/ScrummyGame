using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject playbutton;
    public void onClickPlayy()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("GameMode");
    }

    public void quitgame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    
    // Start is called before the first frame update
    void Start()
    {
       PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
