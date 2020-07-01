using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedMeter : MonoBehaviour
{
    public float nowSpeed;
    public Slider Meter;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Meter.maxValue = 20f;
        Meter.minValue = 5f;

        Meter.value = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        nowSpeed = player.GetComponent<Player>().nowSpeed;

        Meter.value = nowSpeed;
    }
}
