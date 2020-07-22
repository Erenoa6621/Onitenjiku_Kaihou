using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutCounterExit : MonoBehaviour
{
    public GameObject player;
    public float nowSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nowSpeed = player.GetComponent<Player>().nowSpeed;
        this.transform.position += transform.right * 30f * Time.deltaTime;
    }
}
