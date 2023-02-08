using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class problem : MonoBehaviour
{
    public string teamname;
    public Text teamnameText;
    public Text text;
    public GameObject chatbox;
    public int round = 0;
    
    public void openChatbox()
    {


        chatbox.SetActive(true);
        teamnameText.text = teamname;

    }

    public void gotoProblem()
    {

        switch (round)
        {
            case 1:
                round++;
                PlayerPrefs.SetInt("problem", round);
                SceneManager.LoadScene("Require1");

                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;

        }


    }
    
    // Start is called before the first frame update
    void Start()
    {

        round = PlayerPrefs.GetInt("problem")+1;
        teamname = PlayerPrefs.GetString("Teamname");
        Invoke("openChatbox", 7.0f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
