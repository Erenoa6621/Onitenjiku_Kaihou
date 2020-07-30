using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HightScore : MonoBehaviour
{
    // Start is called before the first frame update
    Text timerText;
    private float minute;
    private float seconds;
    public int type;
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (type == 0)
        {
            minute = PlayerPrefs.GetFloat("Minute");
            seconds = PlayerPrefs.GetFloat("Second");
            timerText.text = "ClearTime\n" + minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        else if (type == 1)
        {

            minute = PlayerPrefs.GetFloat("Minute2");
            seconds = PlayerPrefs.GetFloat("Second2");
            timerText.text = "ClearTime\n" + minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        else if (type == 2)
        {
            minute = PlayerPrefs.GetFloat("Minute3");
            seconds = PlayerPrefs.GetFloat("Second3");
            timerText.text = "ClearTime\n" + minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
     }
}
