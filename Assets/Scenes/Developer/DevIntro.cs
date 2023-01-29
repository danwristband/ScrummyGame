using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DevIntro : MonoBehaviour
{
    public string teamname;
    public Text teamnameText;
    public Text text;
    public GameObject chatbox;
    // Start is called before the first frame update


    public void openChatbox()
    {


        chatbox.SetActive(true);
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
