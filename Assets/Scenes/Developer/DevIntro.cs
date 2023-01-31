using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DevIntro : MonoBehaviour
{
    public GameObject video1, video2;
    public string teamname;
    public Text teamnameText;
    public Text text;
    public GameObject chatbox,chatbox2;
    // Start is called before the first frame update


    public void openChatbox()
    {


        chatbox.SetActive(true);
        teamnameText.text = teamname;

    }
    public void openChatbox2()
    {


        chatbox2.SetActive(true);
        teamnameText.text = teamname;

    }

    public void DevIntroconfirm()
    {
        SceneManager.LoadScene("office");
    }
    public void finitePO()
    {
        SceneManager.LoadScene("DevIntro");
    }
    public void startM4()
    { 
        video1.SetActive(false);
        video2.SetActive(true);
        chatbox.SetActive(false);
        Invoke("openChatbox2", 1.0f);
       
    }
    public void startM4part2()
    {
        SceneManager.LoadScene("Minigame 4");

    }
    public void endmini4()
    {
        SceneManager.LoadScene("office");
    }



    public void StartM5()
    {

        SceneManager.LoadScene("1DayPart1");

    }

    void Start()
    {
        teamname = PlayerPrefs.GetString("Teamname");
        Invoke("openChatbox", 1.0f);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
