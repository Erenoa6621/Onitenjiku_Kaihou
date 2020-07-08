using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectCam : MonoBehaviour
{
    public GameObject Player;
    private bool check;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        check = Player.GetComponent<Player>().blur;
        if (check == true)
        {
            transform.position += new Vector3(0.0f, 0.0f, -4.0f);
        }
        else
        {
            transform.position = new Vector3(6.23f, 3.25f, -11.45f);
        }
    }
}
