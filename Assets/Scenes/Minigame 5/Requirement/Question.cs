using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Question : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject choice1,choice2,choice3,choice4 ;
    public GameObject CorrectChoice;
    public int scoremin5 = 5;




    public void choicecheck1()
    {
        if(CorrectChoice == choice1)
        {
            if (scoremin5 <= 1)
            {
                scoremin5 = 1;
            }
            Debug.Log("Pass");
            PlayerPrefs.SetInt("min5require", scoremin5);
            SceneManager.LoadScene("R2");
           

           
        }
        else
        {
            scoremin5--;
            Debug.Log("-1");
        }
       
    }
    public void choicecheck2()
    {
        if (CorrectChoice == choice2)
        {
            if (scoremin5 <= 1)
            {
                scoremin5 = 1;
            }
            Debug.Log("Pass");
            PlayerPrefs.SetInt("min5require", scoremin5);
            SceneManager.LoadScene("R2");
           
        }
        else
        {
            scoremin5--;
            Debug.Log("-1");
        }

    }
    public void choicecheck3()
    {
        if (CorrectChoice == choice3)
        {
            if (scoremin5 <= 1)
            {
                scoremin5 = 1;
            }
            Debug.Log("Pass");
            PlayerPrefs.SetInt("min5require", scoremin5);
            SceneManager.LoadScene("R2");
            
        }
        else
        {
            scoremin5--;
            Debug.Log("-1");
        }

    }
    public void choicecheck4()
    {
        if (CorrectChoice == choice4)
        {
            if (scoremin5 <= 1)
            {
                scoremin5 = 1;
            }
            Debug.Log("Pass"); 
            PlayerPrefs.SetInt("min5require", scoremin5);
            SceneManager.LoadScene("R2");
           
        }
        else
        {
            scoremin5--;
            Debug.Log("-1");
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
