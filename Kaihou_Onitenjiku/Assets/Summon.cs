using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{
    // Start is called before the first frame update
     GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Weapon")
        {
            if (Input.GetKey(KeyCode.A))
            {
                Player.GetComponent<Player>().nowSpeed += 5f;
            }
        }
        if (other.gameObject.tag == "Player")
        {
            Player.GetComponent<Player>().nowSpeed -= 5f;
        }
    }

}
