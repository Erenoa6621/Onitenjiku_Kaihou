using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UltImage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    private bool bulercheck;
    public GameObject bossVS;
    private bool boosVSCheck;
    public Image Slider;

    void Start()
    {
        Slider.color = new Color(255, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        bulercheck = Player.GetComponent<Player>().blur;
        boosVSCheck = bossVS.GetComponent<BossStartTrigger>().bossStart;

        if (bulercheck == true && bossVS == true)
        {
            Slider.color = new Color(255, 0, 0, 255);
        }
        else
        {
            Slider.color = new Color(255, 0, 0, 0);
        }
    }
}
