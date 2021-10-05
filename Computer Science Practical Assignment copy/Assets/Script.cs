using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Script : MonoBehaviour
{

    public TMP_InputField input1;
    public TMP_InputField input2;
    public TextMeshProUGUI uitext;

    // Start is called before the first frame update
    void Start()
    {
        uitext.SetText("");
    }

    public void Button()
    {
        //int area = int.Parse(input1.text) * int.Parse(input2.text) / 2;

       

        if (input1.text == "" || input2.text == "")
        {
        }

        /*else if (input1.text == "" && input2.text == "")
        {
            uitext.SetText("");
        }*/

        else
        {
            float area = float.Parse(input1.text) * float.Parse(input2.text) / 2;

            uitext.SetText("The area of the triangle is " + area.ToString());
        }

        /*
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("");
        }

        else if (string.IsNullOrEmpty(input2.text))
        {
            Debug.Log("");
        }

        else
        {
            uitext.SetText("The area of the triangle is " + area.ToString());
        }
       */

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
