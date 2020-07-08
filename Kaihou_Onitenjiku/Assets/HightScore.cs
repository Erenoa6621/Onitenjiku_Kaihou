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
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        minute = PlayerPrefs.GetFloat("Minute");
        seconds = PlayerPrefs.GetFloat("Second");
        timerText.text ="ClearTime\n"+  minute.ToString("00") + ":" + ((int)seconds).ToString("00");
    }
}
