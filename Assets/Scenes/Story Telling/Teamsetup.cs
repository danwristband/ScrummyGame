using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Teamsetup : MonoBehaviour
{
    public GameObject confirm;
    public string inputTeam;


    public void onClickkkk()
    {   
        Debug.Log(inputTeam.ToString());
        PlayerPrefs.SetString("Teamname", inputTeam.ToString());
        SceneManager.LoadScene("introduce");
    }

    public void ReadStringInput(string s)
    {
        inputTeam = s;
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
