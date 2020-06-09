using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoss : MonoBehaviour
{
    private bool start;
    public Vector3 pos;
    public GameObject playerPos;
    public GameObject mainPlayer;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        start = playerPos.GetComponent<BossStartTrigger>().bossStart;
        pos = this.gameObject.transform.position;
        speed = mainPlayer.GetComponent<Player>().nowSpeed;

        if (start == true)
        {
            transform.position = new Vector3(playerPos.transform.position.x + speed * Time.deltaTime, pos.y, pos.z);
        }
    }
}
