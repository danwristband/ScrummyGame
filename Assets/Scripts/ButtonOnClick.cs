using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonOnClick : MonoBehaviour
{

	public Button yourButton;
	public int score = 5;
	public Text scoretxt;
	public Text passtxt;
	public Text fail1txt;
	public Text fail2txt;
	public Text fail3txt;
	public Text fail4txt;
	//public Image frame;
//	bool check5 = false;



	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		score = 5;
		//frame.gameObject.SetActive(false);
	}
  
    void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		bool check22 = LevelManager.Instance.check22;
        bool check33 = LevelManager.Instance.check33;
		bool checkT = LevelManager.Instance.checkTime;
		bool checkB = LevelManager.Instance.checkBudget;

		if (check22 == true && check33 == true && checkT == true && checkB == true )
        {
            if (score < 0)
            {
				score = 0;
            }
			//frame.gameObject.SetActive(true);
			scoretxt.text = "Score : " + score;
			passtxt.text = "status : " + " You Pass";
			fail1txt.text = "";
			fail2txt.text = "";
			fail3txt.text = "";
			fail4txt.text = "";


		}
		else 
        {
			score--;
		
			if (score < 0)
			{
				score = 0;
			}
			scoretxt.text = "Score : " + score;
			//frame.gameObject.SetActive(true);
			passtxt.text = "";

			if (check22 == false)
			{
				fail1txt.text = "Your Team doesn't match";

            }
            else
            {
				fail1txt.text = "";

			}

			if (check33 == false)
			{
				fail2txt.text = "role and skill doesn't match";


            }
            else
            {
				fail2txt.text = "";


			}

			if (checkT == false)
			{
				fail3txt.text = "Over Delivery Time";

            }
            else
            {
				fail3txt.text = "";
			}

			if (checkB == false)
			{
				fail4txt.text = "Over Budget";
            }
            else
            {
				fail4txt.text = "";

			}


		
		}

	}
}
