using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosCon : MonoBehaviour
{
    public GameObject Player;
    private bool PosChengi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PosChengi = Player.GetComponent<Player>().blur;

        if (PosChengi == true)
        {
            transform.localPosition = new Vector3(8.15f, 3.25f, -15f);
        }
        else
        {
            transform.localPosition = new Vector3(8.15f, 3.25f, -13f);
        }
    }
}
