using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameCtrl : MonoBehaviour
{
    public InputField[] inputPercent;
    public Button yourButton;

    public float[] values;
    public int[] values2;
    public float[] prevalues;
    public Color[] piceColores;
    public Image picePrefab;
   // public bool check = false;

   
    // Start is called before the first frame update
    void Start()
    {  
       //float imageWidth;
       for (int i = 0; i < inputPercent.Length; i++)
        { 
            inputPercent[i].text = " ";
            //inputPercent[i].text;
            //values[i] = float.Parse(inputPercent[i].text);
            //ebug.Log(float.Parse(inputPercent[i].text));
            Debug.Log(inputPercent[i].text);
            Debug.Log(values[i]);
        }
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);




    }
    void TaskOnClick()
    {
        for (int i = 0; i < inputPercent.Length; i++)
        {
            prevalues[i] = values[i];
            values[i] = float.Parse(inputPercent[i].text);

        }
        MakeGraph();
    }


 
/*    void Update()
    {


        for (int i = 0; i < inputPercent.Length; i++)
        {
            prevalues[i] = values[i];
            values[i] = float.Parse(inputPercent[i].text);
        }

        if (prevalues[0] == values[0] && prevalues[1] == values[1] && prevalues[2] == values[2] && prevalues[3] == values[3])
        {
            Debug.Log("LOL");
        }
        else
        {
            MakeGraph();
        }

    }
 */



    void MakeGraph()
    {   
        float total = 0f;
        float zRotation = 0f;
        for (int i = 0; i<values.Length; i++)
        {
            total += values[i];
        }

        for(int i=0; i<values.Length; i++)
        {
            Image newPice = Instantiate (picePrefab) as Image;
            newPice.transform.SetParent (transform, false);
            newPice.color = piceColores[i];
            newPice.fillAmount = values[i] / total;
            newPice.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, zRotation));
            zRotation -= newPice.fillAmount * 360f;
        }
    }
    
}
