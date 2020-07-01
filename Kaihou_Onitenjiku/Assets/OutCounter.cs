using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutCounter : MonoBehaviour
{
    public GameObject Player;
    public GameObject Count;
    private bool Atack;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Atack = Player.GetComponent<Player>().missileCounter;

        if (Atack == true)
        {
            Instantiate(Count, this.gameObject.transform.position, Quaternion.identity);
        }
    }
}
