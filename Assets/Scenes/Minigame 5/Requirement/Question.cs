using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Question : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject choice1,choice2,choice3,choice4 ;
    public GameObject CorrectChoice;
   


    
    public void choicecheck1()
    {
        if(CorrectChoice == choice1)
        {   
            Debug.Log("Pass");
            
            SceneManager.LoadScene("R2");
           

           
        }
        else
        {
            Debug.Log("-1");
        }
       
    }
    public void choicecheck2()
    {
        if (CorrectChoice == choice2)
        {
            Debug.Log("Pass");
            SceneManager.LoadScene("R2");
           
        }
        else
        {
            Debug.Log("-1");
        }

    }
    public void choicecheck3()
    {
        if (CorrectChoice == choice3)
        {
            Debug.Log("Pass");
            SceneManager.LoadScene("R2");
            
        }
        else
        {
            Debug.Log("-1");
        }

    }
    public void choicecheck4()
    {
        if (CorrectChoice == choice4)
        {
            Debug.Log("Pass");
            SceneManager.LoadScene("R2");
           
        }
        else
        {
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
