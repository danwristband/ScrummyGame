using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class T2 : MonoBehaviour
{

    public Protect protect;
    public int[] choiceArray = new int[6];
    public bool[] choiceTrue = new bool[3];
    public Text SceneR2;

    public void fix1()
    {
        if (choiceArray[1] == 0)
        {
            PlayerPrefs.SetInt("databack", 1);
            SceneManager.LoadScene("T3.1");
            //  choiceArray[0] = 1;
            PlayerPrefs.SetInt("data1", 1);

        }
        else
        {

        }

    }
    public void fix2()
    {
        if (choiceArray[2] == 0)
        {
            PlayerPrefs.SetInt("databack", 2);
            SceneManager.LoadScene("T3.2");
            // choiceArray[4] = 1;
            PlayerPrefs.SetInt("data2", 1);
        }
        else
        {

        }

    }
    public void fix3()
    {
        if (choiceArray[5] == 0)
        {
            PlayerPrefs.SetInt("databack", 3);
            SceneManager.LoadScene("T3.3");
            choiceArray[5] = 1;
            PlayerPrefs.SetInt("data5", 1);
        }
        else
        {

        }

    }

    public void checkChoice()
    {

        if (choiceArray[1] == 1 && choiceArray[2] == 1 && choiceArray[5] == 1)
        {

            SceneR2.text = "Pass";
            SceneManager.LoadScene("Test2");
        }
        else if (choiceArray[1] == 1 && choiceArray[2] == 1)
        {

            SceneR2.text = "Fix choice 3";


        }
        else if (choiceArray[2] == 1 && choiceArray[5] == 1)
        {

            SceneR2.text = "Fix choice 1";
        }
        else if (choiceArray[1] == 1 && choiceArray[5] == 1)
        {

            SceneR2.text = "Fix choice 2";

        }
        else if (choiceArray[1] == 1)
        {

            SceneR2.text = "Fix choice 2 and 3";
        }
        else if (choiceArray[2] == 1)
        {

            SceneR2.text = "Fix choice 1 and 3";
        }
        else if (choiceArray[5] == 1)
        {

            SceneR2.text = "Fix choice 1 and 2";
        }
        else
        {

            SceneR2.text = "Fix choice 1  2 and 3 ";
        }

    }



    private void Awake()
    {

        choiceArray[0] = PlayerPrefs.GetInt("data0");
        choiceArray[1] = PlayerPrefs.GetInt("data1");
        choiceArray[2] = PlayerPrefs.GetInt("data2");
        choiceArray[3] = PlayerPrefs.GetInt("data3");
        choiceArray[4] = PlayerPrefs.GetInt("data4");
        choiceArray[5] = PlayerPrefs.GetInt("data5");



        foreach (int i in choiceArray)
        {
            Debug.Log(" " + i);
        }


    }


    // Start is called before the first frame update
    void Start()
    {

        checkChoice();




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
