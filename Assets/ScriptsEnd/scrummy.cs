using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scrummy : MonoBehaviour
{
    public Image[] star;
    public int scoreall;

    public Button next;


    public void newgame()
    {

        SceneManager.LoadScene("GameStarts");
    }

    void Start()
    {
        scoreall = PlayerPrefs.GetInt("player_score");
        Button Confirm = next.GetComponent<Button>();
        next.onClick.AddListener(clickplay);
        


        for (int i = 0; i < 5 - scoreall; i++)
        {
            star[4 - i].gameObject.SetActive(false);
        }

       



    }
    void clickplay()
    {

    }

}
